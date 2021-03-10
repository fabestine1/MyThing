#include <limits.h>
#include <stdlib.h>
#include <time.h>

#include "request_parser.h"
#include "unity.h"
#include "resource_detector.h"

// I rather dislike keeping line numbers updated, so I made my own macro to ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)


void setUp(void)
{
    // This is run before EACH test
}

void tearDown(void)
{
    // This is run after EACH test
}


void test_empty_requestparser(void)
{
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{
		REQUEST_STRUCT request = {0,0};
		TEST_ASSERT_EQUAL(0, request.cmd);
		TEST_ASSERT_EQUAL(0, request.val);
	}
}

void test_cmd0x03(void)
{
	REQUEST_STRUCT request = {0,0};
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{
		
		parseRequest(&request, "cmd=0x03", strlen("cmd=0x03"));
		TEST_ASSERT_EQUAL(3, request.cmd);
	}
}

void test_val0x03(void)
{
	REQUEST_STRUCT request = {0,0};
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{		
		FilterRequestData(&request, "val=0x03", 3, 0, strlen("val=0x03"));
		TEST_ASSERT_EQUAL(3, request.val);
	}
}
void test_cmd0x03separator(void)
{
	REQUEST_STRUCT request = {0,0};
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{	
		parseRequest(&request, "cmd=0x03;", strlen("cmd=0x03;"));
		TEST_ASSERT_EQUAL(3, request.cmd);
	}
}

void test_cmd0x04value0x02request(void)
{
	REQUEST_STRUCT request = {0,0};
	for(int i = 0; i < 10; i++)//multiple loops to check for data corruption
	{		
		parseRequest(&request, "cmd=0x04;val=0x02", strlen("cmd=0x04;val=0x02"));
		TEST_ASSERT_EQUAL(4, request.cmd);
		TEST_ASSERT_EQUAL(2, request.val);
	}	
}


void run_testCases(void) 
{
	UnityBegin();
	RUN_TEST(test_empty_requestparser,1);
	RUN_TEST(test_val0x03,2);
	RUN_TEST(test_cmd0x03,3);
	RUN_TEST(test_cmd0x03separator,4);
	RUN_TEST(test_cmd0x04value0x02request,5);
	UnityEnd();
}

int main (int argc, char * argv[])
{
    run_testCases();
	
	return 0;
}