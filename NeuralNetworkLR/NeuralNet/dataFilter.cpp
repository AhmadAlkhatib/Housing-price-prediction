#include "stdafx.h"
#include "classesDef.h"
#include <iostream>
#include <fstream>

using namespace std;

double deg2rad(double deg) {
	return deg*(3.141592653589793238 / 180);
}

DataFilter::DataFilter(DataParser DP, int size) {
	//cout << "CALLED" << endl;
	m_size = size;
	m_radiusInKM = 0.2; // 200 meters
	m_housesData = DP.sendInput();
	//cout << "SENT" << endl;
	filter();
}

void DataFilter::filter() {
	
	int minHousesCount = 5;
	int HousesCount = 0;
	int centerIndex = m_size - 1; //the index of the house it's price will be estimated

	//cout << "center " << centerIndex << endl;
	Point center, other;

	center = { // the coordinates of the house it's price will be estimated
		stod(m_housesData[centerIndex].longitude),
		stod(m_housesData[centerIndex].latitude)
	};

	/*cout << " LONG " << stod(m_housesData[centerIndex].longitude) << " LAT " << stod(m_housesData[centerIndex].latitude) << endl;*/

	for (int i = 0;i < centerIndex ;i++)
	{
		other = {
			stod(m_housesData[i].longitude),
			stod(m_housesData[i].latitude)
		};
		//cout << " LONG " << stod(m_housesData[i].longitude) << " LAT " << stod(m_housesData[i].latitude) << endl;
		//cout << " DIST " << Distance(center, other) << endl;

		if (Distance(center, other) < m_radiusInKM) {
			HousesCount++;
			pickedHouses.push_back(i);
		}

		if (i == centerIndex - 1) {
			if (HousesCount < minHousesCount) {
				i = 0;
				m_radiusInKM += 0.2;
				pickedHouses.clear();
			}
		}
	}

	cout << " COUNT " << HousesCount << endl;
	pickedHouses.push_back(centerIndex); // push the house it's price will be estimated to the end of the block. the trainer will take this instance as the instance that it's price will be estimated.
}

HousesData* DataFilter::sendInput() {

	HousesData* HD = new HousesData[m_size = pickedHouses.size()];
	int i = 0;
	for (vector<int>::iterator it = pickedHouses.begin(); it != pickedHouses.end(); it++) {
		int index = *it;
		HD[i] = {
			m_housesData[index].location,
			m_housesData[index].size,
			m_housesData[index].rooms,
			m_housesData[index].age,
			m_housesData[index].story,
			m_housesData[index].longitude,
			m_housesData[index].latitude,
			m_housesData[index].price,
		};
		i++;
	}

	return HD;
}

void DataFilter::printData() { // DEBUG FUNCTION
	ofstream ofile;
	ofile.open("filtered houses.txt");

	for (vector<int>::iterator it = pickedHouses.begin(); it != pickedHouses.end();it++) {
		int i = *it;
			ofile << m_housesData[i].location << "-"
				<< m_housesData[i].size << "-"
				<< m_housesData[i].rooms << "-"
				<< m_housesData[i].age << "-"
				<< m_housesData[i].story << "-"
				<< m_housesData[i].longitude << "-"
				<< m_housesData[i].latitude << "-"
				<< m_housesData[i].price << endl;
		
	}
	ofile.close();
}

//calculates great-circle distances between the two points using the ‘Haversine’ formula.
double DataFilter::Distance(Point center, Point other) {

	double lat1 = center.latitude;
	double lon1 = center.longitude;
	double lat2 = other.latitude;
	double lon2 = other.longitude;
	int R = 6371; //earth's radius

	double dlat = deg2rad(lat2 - lat1);
	double dlon = deg2rad(lon2 - lon1);
	
	double a = sin(dlat / 2) * sin(dlat / 2) +
		cos(deg2rad(lat1)) * cos(deg2rad(lat2)) *
		sin(dlon / 2) * sin(dlon / 2);
	double c = 2 * atan2(sqrt(a), sqrt(1 - a));

	return R * c;
}

// Houses count will be called in trainer size parameter 
int DataFilter::getHousesCount() {
	return pickedHouses.size();
}