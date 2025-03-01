all: compile run

compile:
	if not exist bin mkdir bin
	if not exist lib mkdir lib
	g++ -Iinclude -std=c++11 -c src/Kromozom.cpp -o lib/Kromozom.o
	g++ -Iinclude -std=c++11 -c src/main.cpp -o lib/main.o
	g++ -Iinclude -std=c++11 -c src/Gen.cpp -o lib/Gen.o
	g++ -Iinclude -std=c++11 -c src/DNA.cpp -o lib/DNA.o
	g++ -o bin/Program lib/Kromozom.o lib/main.o lib/Gen.o lib/DNA.o

run:
	./bin/Program
