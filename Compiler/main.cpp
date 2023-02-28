#include <iostream>
#include "compiler.h"
#include <string>

int main() {
	compiler com;
	std::string location;
	std::getline(std::cin, location);

	com.Parse(location);

	return 0;
}