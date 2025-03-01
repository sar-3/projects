all: compile run

compile:
	if not exist bin mkdir bin
	if not exist lib mkdir lib
	g++ -Iinclude -std=c++11 -c src/agac.cpp -o lib/agac.o
	g++ -Iinclude -std=c++11 -c src/bagliliste.cpp -o lib/bagliliste.o
	g++ -Iinclude -std=c++11 -c src/main.cpp -o lib/main.o
	g++ -Iinclude -std=c++11 -c src/kuyruk.cpp -o lib/kuyruk.o
	g++ -o bin/Program lib/agac.o lib/bagliliste.o lib/main.o lib/kuyruk.o

run:
	./bin/Program
