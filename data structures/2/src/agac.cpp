/*
@file agac.cpp
@description İkili arama ağacı sınıfının işlemlerinin gerçekleştirildiği dosya
@course 2C
@assignment 2. Ödev
@date 25 Aralık 2024
@author Adınız Soyadınız - sare.keyhidar@ogr.sakarya.edu.tr
*/

#include "Agac.hpp"
#include "kuyruk.hpp"
#include <cmath>
#include <cstring>
#include <iostream>
#include <string>

using namespace std;

IkiliAramaAgaci::IkiliAramaAgaci() : kok(nullptr) {}

IkiliAramaAgaci::~IkiliAramaAgaci() {
    sil(kok);
}

void IkiliAramaAgaci::ekle(char veri) {
    kok = ekleYardimci(kok, veri);
}

Dugum* IkiliAramaAgaci::ekleYardimci(Dugum* dugum, char veri) {
    if (!dugum) return new Dugum(veri);
    if (veri < dugum->veri)
        dugum->sol = ekleYardimci(dugum->sol, veri);
    else
        dugum->sag = ekleYardimci(dugum->sag, veri);
    return dugum;
}

char** cizimAlaniOlustur(int satirSayisi, int genislik) {
    char** cizim = new char*[satirSayisi];
    for (int i = 0; i < satirSayisi; ++i) {
        cizim[i] = new char[genislik + 1];
        std::memset(cizim[i], ' ', genislik);
        cizim[i][genislik] = '\0';
    }
    return cizim;
}

void cizimAlaniYokEt(char** cizim, int satirSayisi) {
    for (int i = 0; i < satirSayisi; ++i) {
        delete[] cizim[i];
    }
    delete[] cizim;
}

void IkiliAramaAgaci::agacCiz() {
    if (!kok) {
        return;
    }

    int yukseklik = this->yukseklik(kok);
    int genislik = std::pow(2, yukseklik) - 1;
    int satirSayisi = yukseklik * 3 - 2;

    char** cizim = cizimAlaniOlustur(satirSayisi, genislik);

    cizYardim(kok, cizim, 0, genislik / 2, yukseklik);

    for (int i = 0; i < satirSayisi; ++i) {
        std::cout << cizim[i] << std::endl;
    }

    cizimAlaniYokEt(cizim, satirSayisi);
}

void IkiliAramaAgaci::cizYardim(Dugum* dugum, char** cizim, int seviye, int pozisyon, int yukseklik) {
    if (!dugum) return;

    cizim[seviye * 3][pozisyon] = dugum->veri;

    if (dugum->sol) {
        int solPozisyon = pozisyon - std::pow(2, yukseklik - seviye - 2);

        for (int i = solPozisyon; i <= pozisyon; ++i) {
            cizim[seviye * 3 + 1][i] = '.';
        }
        cizim[seviye * 3 + 2][solPozisyon] = '.';

        cizYardim(dugum->sol, cizim, seviye + 1, solPozisyon, yukseklik);
    }

    if (dugum->sag) {
        int sagPozisyon = pozisyon + std::pow(2, yukseklik - seviye - 2);

        for (int i = pozisyon; i <= sagPozisyon; ++i) {
            cizim[seviye * 3 + 1][i] = '.';
        }
        cizim[seviye * 3 + 2][sagPozisyon] = '.';

        cizYardim(dugum->sag, cizim, seviye + 1, sagPozisyon, yukseklik);
    }
}

int IkiliAramaAgaci::yukseklik(Dugum* dugum) {
    if (!dugum) return 0;
    return 1 + std::max(yukseklik(dugum->sol), yukseklik(dugum->sag));
}

int IkiliAramaAgaci::toplam() {
    return toplamHesapla(kok, false);
}

int IkiliAramaAgaci::toplamHesapla(Dugum* dugum, bool solMu) {
    if (!dugum) return 0;
    int solCocuk = toplamHesapla(dugum->sol, true);

    int sagCocuk = toplamHesapla(dugum->sag, false);
    
    int kokDegeri = static_cast<int>(dugum->veri);
    if (solMu) {
        kokDegeri *= 2;
    }
    return solCocuk + kokDegeri + sagCocuk;
}

void IkiliAramaAgaci::agaciAynala() {
    if (!kok) return;

    Kuyruk kuyruk;
    kuyruk.ekle(kok);

    while (!kuyruk.bosMu()) {
        bool hataDurumu = false; 
        Dugum* mevcut = static_cast<Dugum*>(kuyruk.getir(hataDurumu));  
        if (hataDurumu) {
            return; 
        }
        kuyruk.cikar();

        Dugum* gecici = mevcut->sol;
        mevcut->sol = mevcut->sag;
        mevcut->sag = gecici;

        if (mevcut->sol) kuyruk.ekle(mevcut->sol);
        if (mevcut->sag) kuyruk.ekle(mevcut->sag);
    }
}

void IkiliAramaAgaci::agaciSil() {
    if (!kok) return;
    sil(kok); 
    kok = nullptr;
}

void IkiliAramaAgaci::sil(Dugum* dugum) {
    if (dugum) {
        sil(dugum->sol);
        sil(dugum->sag);
        delete dugum;  
    }
}