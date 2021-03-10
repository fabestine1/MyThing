#include "request_parser.h"
#include <RP6ControlLib.h> 		// The RP6 Control Library. 
///<summary>
/// EXPECTED BUFFER DATA FORMAT:
///				CMD=0x01;CMD = 0x01
///<summary>
extern void parseRequest(REQUEST_STRUCT* rstruct, char request_buffer[], size_t buffer_size)
{	
	(*rstruct).cmd = 0;
	(*rstruct).val = 0;
	
   char string_token[200];
    
   uint32_t startpos = 0;
   uint32_t sepindex = 0;
   bool foundmiddle=false;

   uint32_t  i = 0;
   for(; i < buffer_size;i++)
   {
		if(request_buffer[i]==';')
		{
			if(i>startpos&&foundmiddle == true && i != sepindex)
			{
				memcpy(string_token,request_buffer+startpos,i-startpos); 
				string_token[i-startpos] = '\0';
			
				FilterRequestData(rstruct,string_token,sepindex-startpos,0,(i-1));
			
				foundmiddle = false;
				startpos = (i+1);
				sepindex = startpos;
			}
			else
			{
				break;
			}
		}
		else if(request_buffer[i]=='=')
		{
			foundmiddle = true;
			sepindex = i;
		}

   }
   
   if(i>startpos&&foundmiddle == true && i != sepindex)
   {
		memcpy(string_token,request_buffer+startpos,i-startpos); 
		string_token[i-startpos] = '\0';
		
		FilterRequestData(rstruct,string_token,sepindex-startpos,0,i);
   }
  
}

extern void FilterRequestData(REQUEST_STRUCT* request, char request_buffer[], size_t separatorindex, size_t startindex, size_t endindex)
{
	if((separatorindex - startindex) > 0 && (endindex - separatorindex) > 2 && request != NULL)
	{			
		char cmdbuffer[(separatorindex - startindex)+1];
		strncpy(cmdbuffer, request_buffer+startindex, ((separatorindex - startindex)+1));
		
		static char* proper_keys[2] = {"cmd", "val"};
		int index = -1;
		
		for(uint8_t i = 0; i < 2;i++)
		{
			if(strncmp(cmdbuffer, proper_keys[i], strlen(proper_keys[i])) == 0)
			{	 			
				index = i;
				break;
			}
		}
		
		switch(index)
		{
			case 0://CMD
			{
				uint16_t length = (endindex-separatorindex+1);
				
				if(length > 0)
				{
				//				
					char filtervalue [length];
					strncpy(filtervalue, request_buffer+(separatorindex+1), length);
				
						uint16_t value = strtol(filtervalue, NULL, 0);
						
						writeString("{cmd=0x");
						writeInteger(value, HEX);
						writeChar('}');
						
						(*request).cmd = value;
				}
				//
				break;
			}
			case 1: //VAL
			{
				//				
				char filtervalue [(endindex-separatorindex)+1];
				strncpy(filtervalue, request_buffer+(separatorindex+1), (endindex-separatorindex+1));
				
				if(strlen(filtervalue) > 0)
				{
					uint16_t value = strtol(filtervalue, NULL, 0);
					(*request).val = value;
				}
				//
				break;
			}
		}
	}
}