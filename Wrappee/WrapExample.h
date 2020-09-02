#pragma once
#include <comutil.h>

#ifdef MAKEDLL
#  define EXPORT __declspec(dllexport)
#else
#  define EXPORT __declspec(dllimport)
#endif

struct Data
{
	BSTR Text;
	int BigValue;
};



extern "C" {
	EXPORT int TestOne();
	EXPORT int TestTwo();
	EXPORT void TestThree(Data* data);
};

class Internal
{
public:
	int TestFunc();
};
