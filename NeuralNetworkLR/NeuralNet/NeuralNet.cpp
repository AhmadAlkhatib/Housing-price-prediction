#include "stdafx.h"
#include "classesDef.h"
#include <iostream>
#include <fstream>
#include <string>
#include <String.h>
#include <stdio.h>
#include <vector>
#include <sstream>
#include <Windows.h>
#include <math.h>

using namespace std;

API_DLL int estimatePrice(char* str, int size) {

	ofstream ofile;
	char *p = str;
	ofile.open("data.txt");
	while (*p) {
		ofile << *p;
		if (*p == 'w') 
			ofile << endl;
		p++;
	}
	ofile.close();
	
	DataParser dataParser(str, size);
	DataFilter dataFilter(dataParser,size);

	//dataParser.testPrint(to_string(size));
	dataParser.printData(size);
	dataFilter.printData();

	Perceptron trainer(0.00001, dataFilter, dataFilter.getHousesCount());

	int tenThousands = 10000;
	int thousand = 1000;
	int hundred = 100;
	int ten = 10;

	int i = 0;
	while (i < thousand) {
		trainer.GDupdateWeights();
		i++;
	}
	
	//float sum = 0;
	////testing data after training and calculating average error
	//for (int i = trainer.mMax; i < trainer.m;i++) {
	//	sum+=abs(trainer.Test(i));
	//}
	//sum /= (trainer.m - trainer.mMax);

	////ofile.open("estimations.txt", ios::app);
	////ofile << "# of train data " << trainer.mMax << endl;
	//ofile << "# of test data " << trainer.m - trainer.mMax << endl;
	//ofile << "AVERAGE ERROR : " << sum << endl;
	//ofile << trainer.Test(trainer.estimatedHouse) << endl;
	//ofile.close();
	return trainer.h(trainer.estimatedHouse);
}

int main()
{
	
	char *str = " ";
	int size = 0;
	
	DataParser dataParser(str, size);
	DataFilter dataFilter(dataParser, size);

	//dataParser.printData(size);
	dataFilter.printData();

	Perceptron trainer(0.00001, dataFilter, dataFilter.getHousesCount());
	//cout << trainer.m << " " << trainer.mMax <<" "<< trainer.estimatedHouse << endl;

	int hundredThousands = 100000;
	int tenThousands =     10000;
	int thousand =         1000;
	int hundred =          100;
	int ten =              10;
	int i = 0;
	
	while (i <thousand) {
		trainer.GDupdateWeights();
		i++;
		//cout << ((float)i / (float)tenThousands) * 100 << "%" << endl;
	}

	float sum = 0;
	for (int i = trainer.mMax;i < trainer.m-1; i++) {
		//cout << "Estimation = " << trainer.h(i) << " | Original price = " <<trainer.y(i) << endl;
		sum+= abs(trainer.Test(i));
	}

	sum /= (trainer.m - trainer.mMax);
	ofstream ofile;
	ofile.open("estimations.txt", ios::app);
	ofile <<"AVERAGE ERROR : " << sum << endl;
	
	ofile << trainer.Test(trainer.estimatedHouse) << endl;
	ofile.close();
	return 0;
}

//send input with dataParser
//Perceptron::Perceptron(double LR, DataParser DP, int size) {
//	m_learningRate = LR; // set learning rate
//	initializeWeights(); // allocate memory for m_weights and m_temp and initialize value of 1 to m_wights
//	m_housesData = DP.sendInput(); // get a reference to training data
//	m_NumOfFeatures = 4 + 1; //4 features + 1 bias input
//
//	m = size; // set number of instances AKA lines
//	mMax = m*0.7; // split data to 70% training data and 30% test data
//}

Perceptron::Perceptron(double LR, DataFilter DF, int size) {

	m_learningRate = LR; 
	initializeWeights();
	m_housesData = DF.sendInput();
	m_NumOfFeatures = 4 + 1; //4 features + 1 bias input

	m = size ; 
	estimatedHouse = m - 1; // the house that it's price will be estimated relies at the end of the sent struct
	mMax = m - 1; // split data to 70% training data and 30% test data
}

void Perceptron::initializeWeights() {
	m_temp = new double[5]; // will be used in GDUpdate weights
	m_weights = new double[5];
	for (int i = 0;i < 5;i++) {
		m_weights[i] = 1;
	}
}

double Perceptron::h(int i /* current instance of inputs */) {

	cout <<"H "<< i << endl;
	return m_weights[0] +
		m_weights[1] * stoi(m_housesData[i].size) +
		m_weights[2] * stoi(m_housesData[i].rooms) +
		m_weights[3] * stoi(m_housesData[i].age) +
		m_weights[4] * stoi(m_housesData[i].story);
}

int Perceptron::y(int i /* current instance of inputs */) {
	return stoi(m_housesData[i].price);
}

double Perceptron::calculateCost(int numOfFeature) {

	double cost = 0;
	int feature;
	for (int i = 0; i < mMax; i++) {
		feature = chooseFeatureOnIndex(i, numOfFeature);
		cost += (h(i) - y(i)) * feature;
	}
	return cost;
}

//Gradient Descent algorithm to update weights 
void Perceptron::GDupdateWeights() {

	//cout << "prev weight = " << endl;
	for (int i = 0;i < m_NumOfFeatures; i++) {
		m_temp[i] = m_weights[i] - (m_learningRate / mMax)* calculateCost(i);
		cout << "adjusting  " << calculateCost(i)/mMax * m_learningRate << endl;
	}
	for (int i = 0;i < m_NumOfFeatures;i++)  {
		m_weights[i] = m_temp[i];
		cout << "current weight[" << i << "] = " << m_weights[i] << endl;
	}
	
}

// select the feature on the given index value AKA current instance
int Perceptron::chooseFeatureOnIndex(int index, int NumOfFeature) {

	switch (NumOfFeature) {
	case 1:
		return stoi(m_housesData[index].size);
	case 2:
		return stoi(m_housesData[index].rooms);
	case 3:
		return stoi(m_housesData[index].age);
	case 4:
		return stoi(m_housesData[index].story);
	default:
		return 1; // if non of the above then the chosen feature is 0 AKA bias value AKA m_wights[0]
	}
}

void Perceptron::printData() {
	for (int i = 0;i < m;i++) {
		cout << m_housesData[i].size << endl;
	}
}

int Perceptron::Test(int i) {

	float error = 100 - ((float)h(i) / (float)y(i) * 100);

	ofstream ofile;
	ofile.open("estimations.txt", ios::app); //APPEND	
	ofile << "Estimation = " << h(i) << " | Original price = " << y(i) << " OFF BY : "<< error << endl;
	ofile.close();
	return error;
	
}
