#pragma once

#ifdef MAKEDLL
#  define EXPORT __declspec(dllexport)
#else
#  define EXPORT __declspec(dllimport)
#endif

EXPORT class WrapExample 
{
public:
	EXPORT int TestFunc();
};
