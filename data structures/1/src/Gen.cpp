/**       
* @file            G231210012
* @description     Bağlı liste yapısını kullanarak DNA sarmalı oluşturup, çaprazlama ve mutasyon işlemlerini gerçekleştiren sınıfın metotlarını içerir.
* @course          2. Öğretim C grubu
* @assignment      1. Ödev
* @date            27.11.2024
*/ 

#include "Gen.hpp"
#include <iostream>

using namespace std;

Gen::Gen() : bas(nullptr) {}

Gen::Gen(const string& veri) : bas(nullptr) {
    ekle(veri); 
}

Gen::~Gen() {
    while (bas) {
        Dugum* gecici = bas;
        bas = bas->sonraki;
        delete gecici;
    }
}

void Gen::ekle(const string& veri) {
    Dugum* yeniDugum = new Dugum(veri);
    if (!bas) {
        bas = yeniDugum;
    } else {
        Dugum* gecici = bas;
        while (gecici->sonraki) {
            gecici = gecici->sonraki;
        }
        gecici->sonraki = yeniDugum;
    }
}

string Gen::toString() const {
    string sonuc;
    Dugum* gecici = bas;
    while (gecici) {
        sonuc += gecici->veri + " ";
        gecici = gecici->sonraki;
    }
    return sonuc;
}

Dugum* Gen::getBas() const {
    return bas;
}