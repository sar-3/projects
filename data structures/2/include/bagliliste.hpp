#ifndef BAGLILISTE_HPP
#define BAGLILISTE_HPP
#include <iostream>
#include <string>

#include "agac.hpp"

struct BagliListeDugum {
    IkiliAramaAgaci* agac;
    BagliListeDugum* sonraki;

    BagliListeDugum();
    ~BagliListeDugum();
};

class BagliListe {
private:
    BagliListeDugum* bas;
    int boyut;
    int seciliIndeks;
    
public:
    BagliListe();
    ~BagliListe();

    void secimIslemi(char secim, int &seciliIndeks, int &baslangic, int &bitis, int &sayfaBoyutu);
    void dugumEkle(const std::string& satir);
    void dugumSil(int &seciliIndeks, int &baslangic, int sayfaBoyutu);
    void sayfaBosKontrolEt(int &seciliIndeks, int &baslangic, int sayfaBoyutu);
    void dugumleriGoster(int baslangic, int bitis , int seciliIndeks);
    int dugumSayisi();
    
    BagliListeDugum* dugumGetir(int index);
    void dugumAynala(int index);
};

#endif