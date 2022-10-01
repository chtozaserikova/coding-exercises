#include "opencv2/highgui.hpp"
#include "opencv2/imgcodecs.hpp"
#include "opencv2/imgproc.hpp"
#include <iostream>
#include <string>

using namespace std;
using namespace cv;


int main()
{
    string imagePath1 = "cpp\images\sveta1.jpg";
    
    Mat img = imread(imagePath1, IMREAD_COLOR);
    resize(img, img, Size(600, 400));

    if (img.empty())
    {       
        cout << "failed to load image" << endl;
        return EXIT_FAILURE;
    }

    vector<vector<Point> > contours;
    vector<Vec4i> hierarchy;
    Mat gray, binaryImg, contoursImg;
    cvtColor(img, gray, COLOR_RGB2GRAY);

    threshold(gray, binaryImg, 50, 255, THRESH_BINARY);

    findContours(binaryImg, contours, hierarchy, RETR_TREE, CHAIN_APPROX_NONE);

    imshow("Original Image", img);

    for (int contour = 0; contour < contours.size(); contour++)
    {
        Scalar colour(rand() & 0xFF, rand() & 0xFF, rand() & 0xFF);
        drawContours(img, contours, contour, colour, FILLED, 8, hierarchy);
    }
    
    imshow("Contour Image", img);
    waitKey();

    return EXIT_SUCCESS;
}