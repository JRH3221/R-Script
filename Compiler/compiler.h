#pragma once
#include <string>

class compiler {
public:
	void Parse(std::string location);
};

class ErrorLogging {
public:
	static void LogText(std::string text);
};
