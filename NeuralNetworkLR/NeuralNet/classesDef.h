#pragma once
#include <string>
#include <vector>
#include <Windows.h>
#include <cstdio>
#include <math.h>

using namespace std;

#define API_DLL __declspec(dllexport)


extern "C" {
	API_DLL int estimatePrice(char * str, int size);
}


struct HousesData {
	string location;
	//double locationScore;
	string size;
	string rooms;
	string age;
	string story;
	string longitude;
	string latitude;
	string price;
};

class DataParser {
private:
	HousesData *m_housesData;
public:
	DataParser(char *data, int size);
	void parse(char * data, int size);
	void parseRooms(string *rooms, int size);
	void parseAge(string *age, int size);
	void parseStory(string *story, int size);
	void parsePrice(string *prices, int size);
	void fillData(string*, string*, string*, string*, string*, string*, int);
	HousesData* sendInput();
	vector<string> splitOnDelimiter(char * str, char delim);
	void printData(int);	
	void testPrint(string);
	//void calcLocationScore(int size);
};

struct Point {
	double longitude;
	double latitude;
};

class DataFilter {
private:
	HousesData* m_housesData;
	int m_size;
	float m_radiusInKM;
	vector<int> pickedHouses;
	double Distance(Point center, Point other);
public:
	int getHousesCount();
	DataFilter(DataParser dataParser, int size);
	void filter();
	HousesData* sendInput();
	void printData();
};

class Perceptron{
private:
	HousesData* m_housesData; // a pointer to m_housesData in DataParser class will be set by the constructor

	double m_learningRate; // will be initialized in the constructor
	double *m_weights; // will be initialized in the constructor
	double *m_temp; // will be intialized in the constructor. Holds temporary *m_wights value to update them at once
	int m_NumOfFeatures; // will be initialized in the constructor

	void initializeWeights(); 
	int chooseFeatureOnIndex(int i,int numOfFeature); // returns the corresponding feature to the current weight value at the current instance of housesData data block
	double calculateCost(int index); // cost function will be called in GDupdateWeights function to adjust weight values

public:
	
	// 3 MEMEBERS WILL BE ENCAPSULATED LATER !!!!!!!!!!!!!!!
	int m; // number of instances AKA house's count AKA lines 
	int mMax; // 0->mMax is number of instances that will be taken to train trainer. 
 	          // mMax->m is the data that will be taken to test the trainer.
	int estimatedHouse; // the index of the house that it's price will be estimated
	//Perceptron(double LR, DataParser DP, int size); // costructor function will initialize private members
	
	Perceptron(double LR, DataFilter DF, int size); // overloaded constructor for convenience
	void GDupdateWeights(); // gradient descent
	int y(int index); // returns price for the current instance
	double h(int index); // hypothesis function will calculate an estimation of the price for the current instance
	void printData();
	int Test(int i);
};
