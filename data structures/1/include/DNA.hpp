#ifndef DNA_HPP
#define DNA_HPP

#include "Kromozom.hpp"
#include <string>
using namespace std;

class DNA {
private:
    Dugum* bas;

public:
    DNA();  
    ~DNA(); 

    void kromozomEkle(const Kromozom& kromozom);
    void caprazla(size_t indeks1, size_t indeks2);
    void mutasyon(size_t kromozomIndeks, size_t genIndeks);
    void yazdir() const;
    void dosyadanOku(const string& dosyaAdi);
    void belirliGenYazdir() const;
    void otomatikIslemleriYurut(const string& dosyaAdi);
};

#endif