/**       
* @file            G231210012
* @description     Bağlı liste yapısını kullanarak DNA sarmalı oluşturup, çaprazlama ve mutasyon işlemlerini gerçekleştiren sınıfın metotlarını içerir.
* @course          2. Öğretim C grubu
* @assignment      1. Ödev
* @date            27.11.2024
*/ 

#include "DNA.hpp"
#include <iostream>

using namespace std;    

int main() {
    DNA dna;

    string dosyaAdi = "Dna.txt";
    dna.dosyadanOku(dosyaAdi);

    int secim;
    do {
        cout << "\nSecenekler:\n"
                  << "1. Caprazlama\n"
                  << "2. Mutasyon\n"
                  << "3. Otomatik Islemler\n"
                  << "4. Ekrana Yazdir\n"
                  << "5. Tum Populasyonu Goster\n"
                  << "6. Cikis\n"
                  << "Seciminizi girin: ";
        cin >> secim;

        switch (secim) {
        case 1: {
            size_t indeks1, indeks2;
            cout << "Caprazlama icin iki kromozom indeksi girin (orn: 0 1): ";
            cin >> indeks1 >> indeks2;

            dna.caprazla(indeks1, indeks2);
            cout << "\nCaprazlama yapilmistir." << endl;
            break;
        }
        case 2: {
            size_t kromozomIndeks, genIndeks;
            cout << "Mutasyon icin kromozom ve gen indekslerini girin (orn: 0 1): ";
            cin >> kromozomIndeks >> genIndeks;

            dna.mutasyon(kromozomIndeks, genIndeks);
            cout << "\nMutasyon yapilmistir." << endl;
            break;
        }
        case 3:
            dna.otomatikIslemleriYurut("Islemler.txt");
            cout << "\nIslemler.txt dosyasindaki islemler tamamlandi." << endl;
            break;
        
        case 4:
            cout << "\nKromozomlarin belirli genleri:" << endl;
            dna.belirliGenYazdir();
            break;

        case 5:
            cout << "\nDNA Populasyonu:" << endl;
            dna.yazdir();
            break;

        case 6:
            std::cout << "Programdan cikiliyor...\n";
            break;

        default:
            cerr << "Hata: Gecersiz secim!" << endl;
        }
    } while (secim != 6);

    return 0;
}