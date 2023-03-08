#include "compiler.h"
#include <string>
#include <iostream>
#include <fstream>
#include <vector>

void createFile() {
	std::ofstream pyfile ("main.py");

	pyfile << "Invalid Compile Creation";

	pyfile.close();
}

bool FileRead(std::string location) { //Read name of file to make sure it's valid
	std::string concatName;
	for (int i = location.length() - 8; i < location.length(); ++i) {
		concatName += location[i];
	}
	if (concatName == ".rscript") {
		return true;
	}
	ErrorLogging::LogText("Must Use .rscript");
	return false;
}

void compiler::Parse(std::string location) {
	if (!FileRead(location)) return; //Make sure the file is actually a .rscript

	std::ifstream sr(location);

	char character;
	std::string point;

	if (sr.is_open()) {
		std::cout << "Compiling...";

		std::vector<std::string> syntax = { "print" };

		createFile();

		//while (sr) {

		//}
	}
	else { //Can't Open File
		ErrorLogging::LogText("Invalid Script Location");
		return;
	}
}