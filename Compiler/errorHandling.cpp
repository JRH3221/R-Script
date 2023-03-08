#include <iostream>
#include "compiler.h"
#include <string>

void ErrorLogging::LogText(std::string text) {
	std::cout << "\nCompiling Filed with the error: " << '"' << text << '"' << " \nYou can refer to documentation for help for this error" << std::endl;
}
