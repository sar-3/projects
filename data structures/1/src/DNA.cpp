/**       
* @file            G231210012
* @description     Bağlı liste yapısını kullanarak DNA sarmalı oluşturup, çaprazlama ve mutasyon işlemlerini gerçekleştiren sınıfın metotlarını içerir.
* @course          2. Öğretim C grubu
* @assignment      1. Ödev
* @date            27.11.2024
*/ 

#include "DNA.hpp"
#include <iostream>
#include <fstream>
#include <sstream>

using namespace std;

DNA::DNA() : bas(nullptr) {} 

DNA::~DNA() { // Yıkıcı
    while (bas) {
        Dugum* gecici = bas;
        bas = bas->sonraki;
        delete gecici;
    }
}

void DNA::kromozomEkle(const Kromozom& kromozom) {
    Dugum* yeniDugum = new Dugum(kromozom.toString());
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

void DNA::yazdir() const {
    Dugum* gecici = bas;
    while (gecici) {
        cout << gecici->veri << endl;
        gecici = gecici->sonraki;
    }
}

void DNA::dosyadanOku(const string& dosyaAdi) {
    ifstream dosya(dosyaAdi);
    string satir;

    if (dosya.is_open()) {
        while (getline(dosya, satir)) {
            Kromozom kromozom(satir); 
            kromozomEkle(kromozom);
        }
        dosya.close();
    } else {
        cerr << "Hata: Dosya acilamadi: " << dosyaAdi << endl;
    }
}

void DNA::caprazla(size_t indeks1, size_t indeks2) {
    Dugum* birinci = nullptr;
    Dugum* ikinci = nullptr;
    Dugum* gecici = bas;
    size_t mevcutIndeks = 0;

    while (gecici) {
        if (mevcutIndeks == indeks1) birinci = gecici;
        if (mevcutIndeks == indeks2) ikinci = gecici;
        if (birinci && ikinci) break;
        gecici = gecici->sonraki;
        ++mevcutIndeks;
    }

    if (!birinci || !ikinci) {
        cerr << endl << "!!!Hata: Gecersiz kromozom indeksleri!!!" << endl;
        return;
    }

    Kromozom kromozom1(birinci->veri);
    Kromozom kromozom2(ikinci->veri);

    Kromozom yeni1, yeni2;
    size_t orta1 = kromozom1.genSayisi() / 2;
    size_t orta2 = kromozom2.genSayisi() / 2;

    kromozom1.bolVeEkle(orta1, true, yeni1);  
    kromozom2.bolVeEkle(orta2, false, yeni1); 

    kromozom1.bolVeEkle(orta1, false, yeni2); 
    kromozom2.bolVeEkle(orta2, true, yeni2);  

    kromozomEkle(yeni1);
    kromozomEkle(yeni2);
}

void DNA::mutasyon(size_t kromozomIndeks, size_t genIndeks) {
    Dugum* gecici = bas;
    size_t mevcutIndeks = 0;

    while (gecici) {
        if (mevcutIndeks == kromozomIndeks) break;
        gecici = gecici->sonraki;
        ++mevcutIndeks;
    }

    if (!gecici) {
        cerr << endl << "!!!Hata: Gecersiz kromozom indeksi!!!" << endl;
        return;
    }

    Kromozom kromozom(gecici->veri);
    kromozom.mutasyon(genIndeks);
    gecici->veri = kromozom.toString();
}

void DNA::otomatikIslemleriYurut(const string& dosyaAdi) {
    ifstream dosya(dosyaAdi);
    string satir;

    if (dosya.is_open()) {
        while (getline(dosya, satir)) {
            istringstream iss(satir);
            char islem;
            size_t indeks1, indeks2;

            iss >> islem >> indeks1 >> indeks2;

            if (islem == 'C') {
                caprazla(indeks1, indeks2);
            } else if (islem == 'M') {
                mutasyon(indeks1, indeks2);
            } else {
                cerr << endl << "Hata: Gecersiz islem!" << endl;
            }
        }
        dosya.close();
    } else {
        cerr << endl << "!!!Hata: Islemler.txt dosyasi acilamadi.!!!" << endl;
    }
}

void DNA::belirliGenYazdir() const {
    Dugum* gecici = bas;
    while (gecici) {
        Kromozom kromozom(gecici->veri);
        Dugum* genDugum = kromozom.getBas();
        string ilkGen = genDugum->veri;
        string belirliGen = ilkGen;

        Dugum* tersBas = nullptr;
        while (genDugum) {
            Dugum* yeniDugum = new Dugum(genDugum->veri);
            yeniDugum->sonraki = tersBas;
            tersBas = yeniDugum;
            genDugum = genDugum->sonraki;
        }

        Dugum* tersDugum = tersBas;
        while (tersDugum) {
            if (tersDugum->veri < ilkGen) {
                belirliGen = tersDugum->veri;
                break;
            }
            tersDugum = tersDugum->sonraki;
        }

        while (tersBas) {
            Dugum* gecici = tersBas;
            tersBas = tersBas->sonraki;
            delete gecici;
        }

        cout << belirliGen << " ";
        gecici = gecici->sonraki;
    }
    cout << endl;
}