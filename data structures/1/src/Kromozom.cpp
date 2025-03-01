/**       
* @file            G231210012
* @description     Bağlı liste yapısını kullanarak DNA sarmalı oluşturup, çaprazlama ve mutasyon işlemlerini gerçekleştiren sınıfın metotlarını içerir.
* @course          2. Öğretim C grubu
* @assignment      1. Ödev
* @date            27.11.2024
*/ 

#include "Kromozom.hpp"
#include <iostream>

Kromozom::Kromozom() : bas(nullptr) {}

Kromozom::Kromozom(const string& veri) : bas(nullptr) {
    size_t baslangic = 0;
    size_t bitis = 0;

    while (bitis != string::npos) {
        bitis = veri.find(' ', baslangic);
        string genVeri = veri.substr(baslangic, bitis - baslangic);
        if (!genVeri.empty()) {
            genEkle(Gen(genVeri));
        }
        baslangic = bitis + 1;
    }
}

Kromozom::~Kromozom() {
    while (bas) {
        Dugum* gecici = bas;
        bas = bas->sonraki;
        delete gecici;
    }
}

void Kromozom::genEkle(const Gen& gen) {
    Dugum* yeniDugum = new Dugum(gen.toString());
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

size_t Kromozom::genSayisi() const {
    size_t sayi = 0;
    Dugum* gecici = bas;
    while (gecici) {
        ++sayi;
        gecici = gecici->sonraki;
    }
    return sayi;
}

void Kromozom::bolVeEkle(size_t orta, bool soldan, Kromozom& yeniKromozom) {
    Dugum* gecici = bas;
    size_t mevcutIndeks = 0;
    size_t genSayisi = this->genSayisi();

    while (gecici) {
        if (genSayisi % 2 == 0) { 
            if (soldan && mevcutIndeks < orta) {
                yeniKromozom.genEkle(Gen(gecici->veri));
            } else if (!soldan && mevcutIndeks >= orta) {
                yeniKromozom.genEkle(Gen(gecici->veri));
            }
        } else { 
            if (soldan && mevcutIndeks < orta) {
                yeniKromozom.genEkle(Gen(gecici->veri));
            } else if (!soldan && mevcutIndeks > orta) { 
                yeniKromozom.genEkle(Gen(gecici->veri));
            }
        }
        gecici = gecici->sonraki;
        ++mevcutIndeks;
    }
}

void Kromozom::mutasyon(size_t genIndeks) {
    Dugum* gecici = bas;
    size_t mevcutIndeks = 0;

    while (gecici) {
        if (mevcutIndeks == genIndeks) {
            gecici->veri = "X ";
            return;
        }
        gecici = gecici->sonraki;
        ++mevcutIndeks;
    }

    cerr << endl << "!!!Hata: Gecersiz gen indeksi!!!" << endl;
}

string Kromozom::toString() const {
    string sonuc;
    Dugum* gecici = bas;
    while (gecici) {
        sonuc += gecici->veri;
        gecici = gecici->sonraki;
    }
    return sonuc;
}

Dugum* Kromozom::getBas() const {
    return bas;
}