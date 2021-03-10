#include "unity.h"
#include "request_parser.h"
#include "RP6ControlLib.h"

/* Needed for unity testing framework.. */
/* Check out define in makfile: 
 *	CDEFS = -DUNITY_INT_WIDTH=16 -DUNITY_OUTPUT_CHAR=rp6_output_char_for_unity	
 */
int rp6_output_char_for_unity(int character)
{
	writeChar(character);
	return 0;
}


void setUp(void) 
{
	writeString_P("\nSetup test...");
}

void tearDown(void)
{
	writeString_P("...cleaned up after test.\n");
}

void test_empty_requestparser(void)
{
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{
		REQUEST_STRUCT request = {0,0};
		TEST_ASSERT_EQUAL(0, request.cmd);
		TEST_ASSERT_EQUAL(0, request.val);
	}
	writeString_P("Test `test_empty_requestparser` passed\n");
}

void test_cmd0x01request(void)
{
	REQUEST_STRUCT request = {0,0};
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{
		
		parseRequest(&request, "cmd=0x01", strlen("cmd=0x01"));
		TEST_ASSERT_EQUAL(1, request.cmd);
	}
	writeString_P("Test `test_cmd0x01request` passed\n");
}
void test_value0x01(void)
{
	REQUEST_STRUCT request = {0,0};
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{		
		FilterRequestData(&request, "val=0x02", 3, 0, strlen("val=0x02"));
		TEST_ASSERT_EQUAL(2, request.val);
	}
	writeString_P("Test `test_value0x01` passed\n");
}

void test_cmd0x01requestseparator(void)
{
	REQUEST_STRUCT request = {0,0};
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{	
		parseRequest(&request, "cmd=0x01;", strlen("cmd=0x01;"));
		TEST_ASSERT_EQUAL(1, request.cmd);
	}
	writeString_P("Test `test_cmd0x01requestseparator` passed\n");
}

void test_cmd0x01value0x02request(void)
{
	REQUEST_STRUCT request = {0,0};
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{		
		parseRequest(&request, "cmd=0x01;val=0x02", strlen("cmd=0x01;val=0x02"));
		TEST_ASSERT_EQUAL(0, request.cmd);
		TEST_ASSERT_EQUAL(0, request.val);
	}	
	writeString_P("Test `test_cmd0x01value0x02request` passed\n");
}


void run_testCases(void) 
{
	writeString_P("Start running test cases:\n");
	UnityBegin();
	//RUN_TEST(test_empty_requestparser,1);
	//RUN_TEST(test_cmd0x01request,2);
	//RUN_TEST(test_value0x01,3);
	//RUN_TEST(test_cmd0x01requestseparator,4);
	RUN_TEST(test_cmd0x01value0x02request,5);
	UnityEnd();
	writeString_P("...done.\n");
}
