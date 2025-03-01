/*
@file kuyruk.cpp
@description Kuyruk sınıfının işlemlerinin gerçekleştirildiği dosya
@course 2C
@assignment 2. Ödev
@date 25 Aralık 2024
@author Adınız Soyadınız - sare.keyhidar@ogr.sakarya.edu.tr
*/
#include "kuyruk.hpp"

DugumKuyruk::DugumKuyruk(void* veri) : veri(veri), sonraki(nullptr) {}

Kuyruk::Kuyruk() : on(nullptr), arka(nullptr), boyut(0) {}

Kuyruk::~Kuyruk() {
    while (!bosMu()) {
        cikar();
    }
}

bool Kuyruk::ekle(void* veri) {
    DugumKuyruk* yeniDugum = new DugumKuyruk(veri);
    if (arka) {
        arka->sonraki = yeniDugum;
    }
    arka = yeniDugum;
    if (!on) {
        on = arka;
    }
    boyut++;
    return true;
}

void* Kuyruk::getir(bool& hataDurumu) {
    if (bosMu()) {
        hataDurumu = true;
        return nullptr;
    }
    hataDurumu = false;
    return on->veri;
}

bool Kuyruk::cikar() {
    if (bosMu()) {
        return false;
    }
    DugumKuyruk* silinecek = on;
    on = on->sonraki;
    if (!on) {
        arka = nullptr;
    }
    delete silinecek;
    boyut--;
    return true;
}

bool Kuyruk::bosMu() const {
    return on == nullptr;
}

int Kuyruk::uzunluk() const {
    return boyut;
}