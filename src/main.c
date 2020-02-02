#include <stdio.h>

#define ARR_LENGTH 4

int main()
{
    int numbers[ARR_LENGTH] = { 11, 15, 3, 7 };
    int k = 17;
    char finded = 0;

    for(int i = 0; i < (ARR_LENGTH + 1); i++)
    {
        for(int j = i+1; j < ARR_LENGTH; j++)
        {
            if(numbers[i] + numbers[j] == k)
            {
                printf("Finded -> %d + %d = %d\n", numbers[i], numbers[j], k);
                finded = 1;
            }
        }
    }

    if(finded == 0) 
    {
        printf("not found...\n");
    }

    return 0;
}
