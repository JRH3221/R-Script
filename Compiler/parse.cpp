#include "compiler.h"
#include <string>
#include <iostream>
#include <fstream>

void compiler::Parse(std::string location) {
	std::ifstream sr("D:/github/Repo/R-Script/Example Scripts/Test1.rscript");

	if (sr.is_open()) {
		std::cout << "Valid Location";
	}
	else {
		std::cout << "Invalid Location" << std::endl;
		return;
	}
}