#pragma once
#include <string>
#include <set>
#include <map>

class compiler {
public:
	void Parse(std::string location);
	std::set<std::string> syntax = {"print"};
	std::set<char> breaks = { '(',')' };
	std::map<std::string, std::string> functions;
};

class ErrorLogging {
public:
	static void LogText(std::string text);
};
