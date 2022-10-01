#include <opencv2/core.hpp>
#include <opencv2/imgcodecs.hpp>
#include <opencv2/highgui.hpp>
#include "opencv2/imgproc.hpp"
#include <iostream>

using namespace std;

int main()
{
    string image_path1 = "cpp\images\sveta1.jpg";
    string image_path2 = "cpp\images\sveta2.jpg";

    cv::Mat astro1 = cv::imread(image_path1, cv::IMREAD_COLOR);
    cv::Mat astro2 = cv::imread(image_path2, cv::IMREAD_COLOR);

    if(astro2.empty())
    {
        cout << "Не могу прочитать изображение: " << endl;
        return 1;
    }

    cv::rotate(astro2, astro2, cv::ROTATE_90_COUNTERCLOCKWISE);
    cv::resize(astro2, astro2, cv::Size(300,300));

   // cv::Vec3b colorModification = {231, 54, 154};

    for(int i = 0; i < astro2.rows; i++)
    {
        for(int j = 0; j < astro2.cols; j++)
        {
            //astro2.at<cv::Vec3b>(i, j) = colorModification;

            cv::Vec3b bgrPixel = astro2.at<cv::Vec3b>(i, j);

            cout << "bgr: " << bgrPixel << endl;

            //Grayscale = (R + G + B / 3)


            unsigned char grayScale = (bgrPixel[2] + bgrPixel[1] + bgrPixel[0]) / 3;

            astro2.at<cv::Vec3b>(i, j) = {grayScale, grayScale, grayScale};

            cv::Vec3b grayPixel = astro2.at<cv::Vec3b>(i, j);

            cout << "gray: " << grayPixel << endl;
        }
    }

    cv::imshow("Display window", astro2);
    int k = cv::waitKey(0); 

    if(k == 's'){
        cv::imwrite("sveta_night.png", astro2);
    }
    return 0;
}