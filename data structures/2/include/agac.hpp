/**
 * @file agac.hpp
 * @description İkili arama ağacı için başlık dosyası.
 * @course 2C
 * @assignment 2. Ödev
 * @date 16 Aralık 2024
 * @author SARE NUR KEYHİDAR - 
 */

#ifndef AGAC_HPP
#define AGAC_HPP

#include <iostream>
#include <string>
#include <iomanip>
#include <cmath>
#include <cstring>

struct Dugum {
    char veri;       
    Dugum* sol;     
    Dugum* sag;      

    Dugum(char veri) : veri(veri), sol(nullptr), sag(nullptr) {}
};

class IkiliAramaAgaci {
private:
    Dugum* kok; 

    int yukseklik(Dugum* kok); 
    Dugum* ekleYardimci(Dugum* dugum, char veri); 
    void sil(Dugum* dugum); 
    void cizYardim(Dugum* dugum, char** cizim, int seviye, int pozisyon, int yukseklik); 
    int toplamHesapla(Dugum* dugum, bool solMu);

public:
    IkiliAramaAgaci(); 
    ~IkiliAramaAgaci(); 

    void ekle(char veri); 
    void agacCiz();       
    void agaciAynala();   
    void agaciSil();      
    int toplam();         
};

#endif
