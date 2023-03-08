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
	
	std::string word;

	if (sr.is_open()) {
		std::cout << "Compiling..."; //Show that compiling has started
		createFile(); //Create target python file

		while (sr >> word) {
			if (syntax.find(word) != syntax.end()) {
				//contained in syntax list
			}
		}
	}
	else { //Can't Open File
		ErrorLogging::LogText("Invalid Script Location");
		return;
	}
}