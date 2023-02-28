#include "compiler.h"
#include <string>
#include <iostream>
#include <fstream>
#include <vector>

void createFile() {
	std::ofstream pyfile ("main.py");

	pyfile << "testing text";

	pyfile.close();
}

void compiler::Parse(std::string location) {
	std::ifstream sr(location);

	char character;
	std::string point;

	if (sr.is_open()) {
		std::cout << "Compiling...";

		std::vector<std::string> syntax = { "print" };

		createFile();

		while (sr) {
			while (true) {
				if (sr) {
					character = sr.get();
					if (character == ' ') break;
					point.push_back(character);
				}
				else {
					break;
				}
			}
			std::cout << point;
		}
		std::cout << "end of file";
	}
	else {
		std::cout << "Invalid Location" << std::endl;
		return;
	}
}