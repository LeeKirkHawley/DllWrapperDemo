#pragma once

#ifdef MAKEDLL
#  define EXPORT __declspec(dllexport)
#else
#  define EXPORT __declspec(dllimport)
#endif

extern "C" {
	EXPORT int TestOne();
	EXPORT int TestTwo();
};

class WrapExample
{
public:
	int TestFunc();
};
