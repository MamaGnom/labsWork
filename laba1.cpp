#include <iostream>
#include <cstdlib>
#include <ctime>
#include <cmath>
#include <cstring>
#include <iomanip>  // для std::setw и std::setprecision



using namespace std;

// Задача 1
void task1() {
    cout << "=== ЗАДАЧА 1 ===" << endl;

    int n = 20;
    int arr[20] = { 0 };
    int output[20];
    int output_size = 0;

    // Заполняем случайными числами
    for (int i = 0; i < n; i++) {
        arr[i] = rand() % 10 + 1;
    }

    // Считаем частоту
    int freq[11] = { 0 };
    for (int i = 0; i < n; i++) {
        freq[arr[i]]++;
    }

    // Находим самый частый элемент
    int max_freq = 0;
    int most_frequent = 0;
    for (int i = 1; i <= 10; i++) {
        if (freq[i] > max_freq) {
            max_freq = freq[i];
            most_frequent = i;
        }
    }

    // Заполняем выходной массив
    for (int i = 1; i <= 10; i++) {
        if (freq[i] >= 2) {
            output[output_size++] = i;
        }
    }

    cout << "Вход: [ ";
    for (int i = 0; i < n; i++) {
        cout << arr[i] << " ";
    }
    cout << "]" << endl;

    cout << "Выход: [ ";
    for (int i = 0; i < output_size; i++) {
        cout << output[i] << " ";
    }
    cout << "]" << endl;

    cout << "чаще всего встречается  = " << most_frequent << endl;
}

// Задача 2
void task2() {
    cout << "\n=== ЗАДАЧА 2 ===" << endl;

    const int rows = 5;
    const int cols = 3;
    double arr2d[rows][cols];
    double arr1d[rows * cols];

    // Заполняем массив с абсолютными значениями
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            arr2d[i][j] = abs(sin(i - j) + cos(i + j));
        }
    }

    // Выводим 2D массив
    std::cout << "2D массив (только положительные значения):" << std::endl;
    for (int i = 0; i < rows; i++) {
        std::cout << "[ ";
        for (int j = 0; j < cols; j++) {
            std::cout << std::fixed << std::setprecision(4) << std::setw(8) << arr2d[i][j] << " ";
        }
        std::cout << "]" << std::endl;
    }

    // Преобразуем в 1D (снизу вверх, слева направо)
    int index = 0;
    for (int i = rows - 1; i >= 0; i--) {
        for (int j = 0; j < cols; j++) {
            arr1d[index++] = arr2d[i][j];
        }
    }

    // Выводим 1D массив
    std::cout << "\n1D массив:" << std::endl << "[ ";
    for (int i = 0; i < (rows * cols); i++) {
        std::cout << std::fixed << std::setprecision(4) << std::setw(8) << arr1d[i] << " ";
    }
    std::cout << "]" << std::endl;

}

// Задача 3
char* my_strncat(char* dest, const char* src, int maxlen) {
    char* start = dest;

    // Находим конец dest
    while (*dest != '\0') {
        dest++;
    }

    // Копируем не более maxlen символов
    int count = 0;
    while (*src != '\0' && count < maxlen) {
        *dest = *src;
        dest++;
        src++;
        count++;
    }

    *dest = '\0';
    return start;
}

void task3() {
    cout << "\n=== ЗАДАЧА 3 ===" << endl;

    char dest[100] = "Hello";
    char src[] = " World!";

    cout << "До: \"" << dest << "\"" << endl;
    cout << "Источник: \"" << src << "\"" << endl;

    my_strncat(dest, src, 5);

    cout << "После my_strncat(dest, src, 5): \"" << dest << "\"" << endl;
}

// Меню
int main() {

    setlocale(LC_ALL, "Russian");

   srand(time(0));

    int choice;

    do {
        cout << "\n1 - Задача 1";
        cout << "\n2 - Задача 2";
        cout << "\n3 - Задача 3";
        cout << "\n0 - Выход";
        cout << "\nВыберите: ";
        cin >> choice;

        switch (choice) {
        case 1: task1(); break;
        case 2: task2(); break;
        case 3: task3(); break;
       
        case 0: cout << "Выход" << endl; break;
        default: cout << "Ошибка!" << endl;
        }

    } while (choice != 0);

    return 0;
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
