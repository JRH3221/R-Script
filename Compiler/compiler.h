#pragma once
#include <string>
#include <set>

class compiler {
public:
	void Parse(std::string location);
	std::set<std::string> syntax = { "print" };
};

class ErrorLogging {
public:
	static void LogText(std::string text);
};
