#ifndef DUGUM_HPP
#define DUGUM_HPP

#include <string>

using namespace std;

class Dugum {
public:
    string veri;
    Dugum* sonraki;

    Dugum(const string& veri) : veri(veri), sonraki(nullptr) {}
};

#endif



