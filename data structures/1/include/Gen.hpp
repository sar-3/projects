#ifndef GEN_HPP
#define GEN_HPP

#include "Dugum.hpp"

using namespace std;

class Gen {
private:
    Dugum* bas;

public:
    Gen();
    Gen(const string& veri);
    ~Gen();

    void ekle(const string& veri);
    string toString() const;
    Dugum* getBas() const;
};

#endif