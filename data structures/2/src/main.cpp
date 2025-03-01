/*
@file main.cpp
@description Programın ana dosyası, dosyadan ağaçları okuyarak bağlı liste oluşturur ve işlemleri yapar.
@course 2C
@assignment 2. Ödev
@date 25 Aralık 2024
@author Adınız Soyadınız - sare.keyhidar@ogr.sakarya.edu.tr
*/

#include <iostream>
#include <fstream>
#include "bagliliste.hpp"
using namespace std;

void dosyadanOkuVeListeyeEkle(const string& dosyaAdi, BagliListe& liste) {
    ifstream dosya(dosyaAdi);
    if (!dosya.is_open()) {
        cerr << "Dosya acilamadi: " << dosyaAdi << endl;
        return;
    }

    string satir;
    while (getline(dosya, satir)) {
        liste.dugumEkle(satir);
    }

    dosya.close();
}

int main() {
    BagliListe liste;
    string dosyaAdi = "agaclar.txt";

    dosyadanOkuVeListeyeEkle(dosyaAdi, liste);

    int baslangic = 0;
    int sayfaBoyutu = 10;
    int seciliIndeks = 0;
    char secim;

    do {
        system("cls"); 

        int bitis = min(baslangic + sayfaBoyutu, liste.dugumSayisi());

        liste.dugumleriGoster(baslangic, bitis, seciliIndeks);

        BagliListeDugum* seciliDugum = liste.dugumGetir(seciliIndeks);
        if (seciliDugum) {
            cout << "\nSecili Dugumun Agaci:\n";
            seciliDugum->agac->agacCiz();
        }

        cout << "========================\n";
        cout << "[a] Onceki Dugum   [d] Sonraki Dugum   [w] Agaci Aynala   [s] Agaci Sil   [q] Cikis\n";
        cout << "Seciminiz: ";
        cin >> secim;

        switch (secim) {
        case 'a':
        liste.secimIslemi(secim, seciliIndeks, baslangic, bitis, sayfaBoyutu);
            break;
        case 'd':
        liste.secimIslemi(secim, seciliIndeks, baslangic, bitis, sayfaBoyutu);
            break;
        case 'w':
            if (seciliDugum && seciliDugum->agac) {
                seciliDugum->agac->agaciAynala();
            } else {
                cout << "Agac bulunamadi!\n";
            }
            break;
        case 's':
            if (seciliDugum && seciliDugum->agac) {
                liste.dugumSil(seciliIndeks, baslangic, sayfaBoyutu);
            } else {
                cout << "Silinecek bir dugum bulunamadi!\n";
            }
            break;
        case 'q':
            cout << "Cikis yapiliyor...\n";
            break;
        default:
            cout << "Gecersiz secim!\n";
        }

    } while (secim != 'q');

    return 0;
}