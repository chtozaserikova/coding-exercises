#include <iostream>
#include <cmath>
#include <stdlib.h> 
#include <stdio.h>
#include <conio.h> 
#include <ctime>

using namespace std;

int main (){
    double x[3] = {0.5, 1.0, 0.7}; 
    double weights[3] = {0.4, 0.7, 0.5};
    double sigmoid = (1 / (1 + pow(2.71828, -sigmoid)));
    double y; 
    for (int i; i<2; i++){
        y = sigmoid * ((x[i] * weights[1]) + weights[2]);
    }
    double output = x[0] * weights[0] + x[1] * weights[1] + x[2] * weights[2] + y; 
    output = (1 / (1 + pow(2.71828, - output))); 
    if (output >= 0.8) {
        std::cout << "Ответ 1" << std::endl; 
    }
    else{
        std::cout << "Ответ 0" << std::endl;
    }
    std::cout << output << " Offset: " << y <<std::endl; 
    system("pause");
}