#include "stdafx.h"
#include "classesDef.h"
#include <iostream>
#include <fstream>
#include <string>
#include <String.h>
#include <stdio.h>
#include <vector>

using namespace std;


DataParser::DataParser(char *data, int size) {
	//testPrint("constructorB");
	m_housesData = new HousesData[size];
	//testPrint("constructorA");

	parse(data, size);
}



void DataParser::parse(char * data, int size) {

	//testPrint("parse before pointer allocation");
	//temp arrays
	string *locations = new string[size];
	string *sizes = new string[size];
	string *rooms = new string[size];
	string *age = new string[size];
	string *story = new string[size];
	string *prices = new string[size];
	//testPrint("parse after pointer allocation");

	//get the lines
	//testPrint("splitting lines");
	vector<string>lines = splitOnDelimiter(data, 'w'); // w is an indicator for a new line

													   //iterate on lines vector and use splitOnDelimiter to get the features
	int i = 0;
	for (vector<string>::iterator it = lines.begin(); it != lines.end(); it++) {

		string temp = *it; // get the current line

		testPrint(temp);
		vector<string> features = splitOnDelimiter(&temp[0], 'q'); // q is an indicator of a new feature

																   //DEBUG
		for (vector<string>::iterator iter = features.begin(); iter != features.end();iter++) {
			string temp = *iter;
			testPrint(temp);
		}
		//--------------------------------

		//fill temp arrays to get them ready for parsing 

		m_housesData[i].latitude = features.back();
		features.pop_back();

		m_housesData[i].longitude = features.back();
		features.pop_back();

		prices[i] = features.back();
		features.pop_back();


		story[i] = features.back();
		features.pop_back();

		age[i] = features.back();
		features.pop_back();

		rooms[i] = features.back();
		features.pop_back();

		sizes[i] = features.back();
		features.pop_back();

		locations[i] = features.back();
		features.pop_back();

		i++;
	}
	//testPrint("parse before calling parse functions");
	//parsing
	parseRooms(rooms, size);
	parseAge(age, size);
	parseStory(story, size);
	parsePrice(prices, size);
	//testPrint("parse after calling parse function");

	//testPrint("parse before calling fillData");
	//filling m_housesData
	fillData(locations, sizes, rooms, age, story, prices, size);
	//testPrint("parse after calling fillData");

	//testPrint("parse before calling calclocationScore");
	//Calculating score
	//calcLocationScore(size);
	//testPrint("parse after callign calclocationScore");

	//clean up
	//delete[] locations;
	//delete[] sizes;
	//delete[] rooms;
	//delete[] age;
	//delete[] prices;
	//delete[] prices;
}

void DataParser::parseRooms(string *rooms, int size) {
	//testPrint("parseRooms");

	for (int i = 0;i < size;i++) {

		int k = 0;
		while (rooms[i][k++] != '+'); // iterate to plus sign +

		int n1 = rooms[i][k] - '0'; // get second integer
		int n2 = rooms[i][k - 2] - '0'; // get first integer

		rooms[i] = to_string(n1 + n2); // alter the original array
	}
}

void DataParser::parseAge(string *age, int size) {
	//testPrint("parseAge");
	for (int i = 0;i < size;i++) {
		string temp = "";
		int j = 0;
		while (age[i][j] >= '0' && age[i][j] <= '9') {
			temp += age[i][j];
			j++;
		}
		if (temp == "") //age not founded
			temp = "5";
		age[i] = temp;
	}
}

void DataParser::parseStory(string *story, int size) {

	//testPrint("parseStory");
	for (int i = 0;i < size;i++) {
		if (story[i] == "Yüksek Giris")
			story[i] = "1";
		else if (story[i] == "Çati Kati")
			story[i] = "9";
		else if (story[i] == "Villa Tipi")
			story[i] = "1";
		else if (story[i] == "Zemin Kat" || story[i] == "Giris Kati")
			story[i] = "0";
		else if (story[i] == "Bahçe Kati" || story[i] == "Bodrum Kati")
			story[i] = "-1";
		else if (story[i][0] == 'K')
			story[i] = story[i][story[i].length() - 1];
		else {
			string temp = "";
			int j = 0;
			while (story[i][j] >= '0' && story[i][j] <= '9') { // get the number
				temp += story[i][j];
				j++;
			}
			story[i] = temp;
		}
	}
}

void DataParser::parsePrice(string * price, int size) {

	//testPrint("parsePrice");
	string temp = "";
	bool convert;
	for (int i = 0;i < size; i++) {

		convert = false;
		char *ptr = &price[i][0];

		while (*ptr) {
			if (*ptr == ' ')
				break;

			if (*ptr == '$') {
				convert = true;
				ptr++;
			}
			if (*ptr == '.')
				ptr++;

			temp += *ptr;
			ptr++;
		}
		if (convert) {
			temp = to_string((int)(stoi(temp)*3.81));
		}

		price[i] = temp;
		temp = "";
	}
}

void DataParser::fillData(string *locations, string *sizes, string *rooms, string *age, string *story, string *prices, int size) {

	//testPrint("fillData");
	for (int i = 0;i < size;i++) {
		m_housesData[i].location = locations[i];
		m_housesData[i].size = sizes[i];
		m_housesData[i].rooms = rooms[i];
		m_housesData[i].age = age[i];
		m_housesData[i].story = story[i];
		m_housesData[i].price = prices[i];
	}
}


vector<string> DataParser::splitOnDelimiter(char* str, char delim) {

	//testPrint("split");
	vector<string> tokens;

	string temp = "";

	while (*str) {
		if (*str == delim) {
			tokens.push_back(temp);
			temp = "";
			str++;
		}
		temp += *str;
		str++;
	}
	tokens.push_back(temp);

	return tokens;
}

void DataParser::printData(int size) {

	//testPrint("printData");
	ofstream ofile;
	ofile.open("parsed data.txt");
	for (int i = 0;i < size;i++) {
		ofile << /*m_housesData[i].location << "-" << */ m_housesData[i].size << "-" << m_housesData[i].rooms << "-" << m_housesData[i].age << "-" << m_housesData[i].story << "-" << m_housesData[i].price << "-" <<
			m_housesData[i].longitude << "-" << m_housesData[i].latitude << endl;
	}
	ofile.close();

}

HousesData* DataParser::sendInput() {
	return m_housesData;
}

void DataParser::testPrint(string str) {
	ofstream ofile;
	ofile.open("test1.txt", ofstream::app);
	ofile << str << endl;
	ofile.close();
}

