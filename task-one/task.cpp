#include<iostream>

using namespace std;

class point {
private:
    double x_, y_, z_;

public:
    point() :
        x_(0), y_(0), z_(0) {}
    point(const point& p) :
        x_(p.x_), y_(p.y_), z_(p.z_) {}
    point(const double& x, const double& y, const double& z) :
        x_(x), y_(y), z_(z) {}

//getters and setters, compatible with const objects
    double& x() { return x_; }
    const double& x() const { return x_; }

    double& y() { return y_; }
    const double& y() const { return y_; }

    double& z() { return z_; }
    const double& z() const { return z_; }

};

class rectangle : public point {
private:
    double a_, b_;

public:
    rectangle() :
        point(), a_(0), b_(0) {}
    rectangle(const rectangle& rect) :
        point(rect), a_(rect.a_), b_(rect.b_) {}
    rectangle(const point& p, const double& a, const double& b) :
        point(p), a_(a), b_(b) {}
    rectangle(const double& x, const double& y, const double& z, const double& a, const double& b) :
        point(x, y, z), a_(a), b_(b) {}

//getters and setters, compatible with const objects
    double& a() { return a_; }
    const double& a() const { return a_; }

    double& b() { return b_; }
    const double& b() const { return b_; }

    double area() const { return (b_ * a_); }
};

class prism : public rectangle {
private:
    double h_;

public:
    prism() :
        rectangle(), h_(0) {}
    prism(const double& x, const double& y, const double& z, const double& a, const double& b, const double& h) :
        rectangle (x, y, z, a, b), h_(h){}
    prism(const rectangle& rect, const double& h) :
        rectangle(rect), h_(h) {}
    prism(const point& p, const double& a, const double& b, const double& h) :
        rectangle(p, a, b), h_(h) {}

//getter and setter
    double& h() { return h_; }
//getter for const objects
    const double h() const { return h_; }

    double volume() const { return (area() * h_); }
};



int main() {

    point p1, p2(1, 2, 3);
    const point p3(1.1, 2.2, 3.3);

      cout << "x of point one: " << p1.x() << endl;
      cout << "x of point two: " << p2.x() << endl;

      cout << "x of point three: " << p3.x() << endl;

      cout << "Info of point three" << endl;
      cout << p3.x() << '\t' << p3.y() << '\t' << p3.z() << endl;

      cout << "\nChanging values x, y, z of point one" << endl;
      p1.x() = 1; p1.y() = 10; p1.z() = 100;

      cout << "Info of point one" << endl;
      cout << p1.x() << '\t' << p1.y() << '\t' << p1.z() << endl;


      rectangle rect1, rect2(1,2,3,10.5, 20.5);
      const rectangle rect3(p2,5,5);

        cout << "Info of rectangle one" << endl;
        cout << rect1.x() << '\t' << rect1.y() << '\t' << rect1.z() << '\t'
             << rect1.a() << '\t' << rect1.b() << '\t' << endl;

        cout << "\nChanging values x, y, z, a, b of rectangle one" << endl;
        rect1.x() = 2; rect1.y() = 20; rect1.z() = 200; rect1.a() = 10; rect1.b() = 10;

        cout << "Info of rectangle one" << endl;
        cout << rect1.x() << '\t' << rect1.y() << '\t' << rect1.z() << '\t'
             << rect1.a() << '\t' << rect1.b() << '\t' << endl;

        cout << "\nArea of rectangle one is " << rect1.area() << endl << endl;

        cout << "Info of rectangle three" << endl;
        cout << rect3.x() << '\t' << rect3.y() << '\t' << rect3.z() << '\t'
             << rect3.a() << '\t' << rect3.b() << '\t' << endl;

        cout << "\nArea of rectangle three is " << rect3.area() << endl << endl;


      prism pr1, pr2(1,2,3,10.5,20.5,30.5), pr3(p2,100,200,300);
      const prism pr4(rect3,5);

        cout << "Info of prism four" << endl;
        cout << pr4.x() << '\t' << pr4.y() << '\t' << pr4.z() << '\n'
             << pr4.a() << '\t' << pr4.b() << '\t' << pr4.h() << endl;

        cout << "\nVolume of prism four is " << pr4.volume() << endl;

        cout << "\nChanging values a, b, h of prism one" << endl;
        pr1.a() = 10; pr1.b() = 10; pr1.h() = 10;

        cout << "Info of prism one" << endl;
        cout << pr1.x() << '\t' << pr1.y() << '\t' << pr1.z() << '\n'
             << pr1.a() << '\t' << pr1.b() << '\t' << pr1.h() << endl;

        cout << "\nVolume of prism one is " << pr1.volume() << endl;


    return 0;
}
