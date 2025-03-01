#ifndef KROMOZOM_HPP
#define KROMOZOM_HPP

#include "Gen.hpp"

using namespace std;

class Kromozom {
private:
    Dugum* bas;

public:
    Kromozom(); 
    Kromozom(const string& veri); 
    ~Kromozom();

    void genEkle(const Gen& gen);
    size_t genSayisi() const;
    void bolVeEkle(size_t orta, bool soldan, Kromozom& yeniKromozom);
    void mutasyon(size_t genIndeks);
    string toString() const;
    Dugum* getBas() const;
};

#endif