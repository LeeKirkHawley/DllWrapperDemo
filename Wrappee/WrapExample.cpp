#include "pch.h"
#include "WrapExample.h"
#include <stdlib.h>
#include <stdio.h>


int TestOne()
{
	return 1;
}

int TestTwo()
{
	Internal internal;
	int i = internal.TestFunc();
	return i;
}

void TestThree(Data* data) {
	data->Text = ::SysAllocString(L"Some Text Here");
	data->BigValue = 1345678;
};


int Internal::TestFunc() 
{
	return 2;
}