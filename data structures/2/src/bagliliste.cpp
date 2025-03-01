/*
@file bagliliste.cpp
@description BagliListe sınıfının işlemlerinin gerçekleştirildiği dosya
@course 2C
@assignment 2. Ödev
@date 25 Aralık 2024
@author Adınız Soyadınız - sare.keyhidar@ogr.sakarya.edu.tr
*/

#include "bagliliste.hpp"
#include "agac.hpp"
#include <iostream>
#include <iomanip>

using namespace std;

BagliListeDugum::BagliListeDugum() : agac(new IkiliAramaAgaci()), sonraki(nullptr) {}

BagliListeDugum::~BagliListeDugum() {
    delete agac;
}

BagliListe::BagliListe() : bas(nullptr), boyut(0) {}

BagliListe::~BagliListe() {
    while (bas) {
        BagliListeDugum* silinecek = bas;
        bas = bas->sonraki;
        delete silinecek;
    }
}

void BagliListe::dugumEkle(const std::string& satir) {
    BagliListeDugum* yeni = new BagliListeDugum();
    for (char ch : satir) {
        yeni->agac->ekle(static_cast<int>(ch));
    }
    if (!bas) {
        bas = yeni;
    } else {
        BagliListeDugum* temp = bas;
        while (temp->sonraki) {
            temp = temp->sonraki;
        }
        temp->sonraki = yeni;
    }
    boyut++;
}

void BagliListe::secimIslemi(char secim, int &seciliIndeks, int &baslangic, int &bitis, int &sayfaBoyutu) {
    sayfaBoyutu = 10;
    int toplamDugum = dugumSayisi();

    switch (secim) {
        case 'a':
            if (seciliIndeks > 0) { 
                seciliIndeks--;
                if (seciliIndeks < baslangic) {
                    baslangic = std::max(0, baslangic - sayfaBoyutu);
                    bitis = baslangic + sayfaBoyutu;
                }
            }
            break;

        case 'd':
            if (seciliIndeks < toplamDugum - 1) { 
                seciliIndeks++;
                if (seciliIndeks >= bitis) {
                    baslangic = bitis;
                    bitis = std::min(toplamDugum, bitis + sayfaBoyutu);
                }
            }
            break;
    }
}

void BagliListe::sayfaBosKontrolEt(int &seciliIndeks, int &baslangic, int sayfaBoyutu) {
    int bitis = std::min(baslangic + sayfaBoyutu, boyut);
    
    if (bitis - baslangic <= 0) {
        cout << "Sayfa bos! Onceki sayfaya geciliyor...\n";
        if (baslangic > 0) {
            baslangic = std::max(0, baslangic - sayfaBoyutu);
            seciliIndeks = std::min(baslangic + sayfaBoyutu - 1, boyut - 1);
        } else {
            cout << "Onceki sayfa yok! Islemi iptal ediyoruz.\n";
            seciliIndeks = 0;
        }
    }
}

void BagliListe::dugumSil(int &seciliIndeks, int &baslangic, int sayfaBoyutu) {
    if (seciliIndeks < 0 || seciliIndeks >= boyut) {
        cout << "Gecersiz indeks!" << endl;
        return;
    }

    BagliListeDugum* temp = bas;

    if (seciliIndeks == 0) { 
        bas = bas->sonraki; 
        delete temp;
    } else {
        BagliListeDugum* onceki = nullptr;
        for (int i = 0; i < seciliIndeks; i++) {
            onceki = temp;
            temp = temp->sonraki;
        }

        onceki->sonraki = temp->sonraki;
        delete temp;
    }

    boyut--; 

    if (seciliIndeks >= boyut) {
        seciliIndeks = boyut - 1;
    }

    sayfaBosKontrolEt(seciliIndeks, baslangic, sayfaBoyutu);

    int bitis = std::min(baslangic + sayfaBoyutu, boyut);
    dugumleriGoster(baslangic, bitis, seciliIndeks);
}

void BagliListe::dugumleriGoster(int baslangic, int bitis, int seciliIndeks) {
    BagliListeDugum* temp = bas;
    int index = 0;
    const int width = 10;

    auto yazdirSatir = [&](void (*yazdirici)(BagliListeDugum*, int, int)) {
        temp = bas;
        index = 0;
        while (temp && index < bitis) {
            if (index >= baslangic) {
                cout << left << setw(width);
                yazdirici(temp, index, seciliIndeks);
            }
            temp = temp->sonraki;
            index++;
        }
        cout << endl;
    };

    auto adresYazdir = [](BagliListeDugum* temp, int, int) {
        cout << ((int)temp % 10000) << ".";
    };

    auto toplamYazdir = [](BagliListeDugum* temp, int, int) {
        cout << temp->agac->toplam() << ".";
    };

    auto sonrakiYazdir = [](BagliListeDugum* temp, int, int) {
        if (temp->sonraki == nullptr) {
            cout << "0";
        } else {
            cout << ((int)temp->sonraki % 10000) << ".";
        }
    };

    auto seciliYazdir = [](BagliListeDugum*, int index, int seciliIndeks) {
        if (index == seciliIndeks) {
            cout << "^^^^^^^^^^";
        } else {
            cout << "           ";
        }
    };

    auto altSeciliYazdir = [](BagliListeDugum*, int index, int seciliIndeks) {
        if (index == seciliIndeks) {
            cout << "||||||||||";
        } else {
            cout << "           ";
        }
    };

    yazdirSatir(adresYazdir);
    cout << string(width * (bitis - baslangic ), '-') << endl;

    yazdirSatir(toplamYazdir);
    cout << string(width * (bitis - baslangic ), '-') << endl;

    yazdirSatir(sonrakiYazdir);
    cout << string(width * (bitis - baslangic ), '-') << endl;

    yazdirSatir(seciliYazdir);
    yazdirSatir(altSeciliYazdir);
}

int BagliListe::dugumSayisi() {
    return boyut;
}

BagliListeDugum* BagliListe::dugumGetir(int index) {
    if (index < 0 || index >= boyut) {
        return nullptr;
    }
    BagliListeDugum* temp = bas;
    for (int i = 0; i < index; i++) {
        temp = temp->sonraki;
    }
    return temp;
}

void BagliListe::dugumAynala(int index) {
    BagliListeDugum* dugum = dugumGetir(index);
    if (dugum) {
        dugum->agac->agaciAynala();
    }
}
