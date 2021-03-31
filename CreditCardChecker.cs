using System;

static void Main(string[] args)
{
    long ccNumber;
    do
    {
        ccNumber = Console.ReadLine("Number: ");
    }
    while (ccNumber == 0);

    if (checkCreditCardValidity(ccNumber))
    {
        printCreditCardBrand(ccNumber);
    }
    else
    {
        printf("INVALID\n");
    }
}

bool checkCreditCardValidity(long ccNumber)
{
    int length = findLength(ccNumber);

    return (length == 13 || length == 15 || length == 16) && checksumIsValid(ccNumber);
}

int findLength(long n)
{
    int length;
    for (length = 0; n != 0; n /= 10, length++) ;
    //for(length = 0; n != 0; n /= 10)
    //{
    //    length++;
    //}

    return length;
}

bool checksumIsValid(long ccNumber)
{
    int sum = 0;
    int wn;
    long ccNumberWorking = ccNumber;

    while (ccNumberWorking > 0)
    {
        sum += ccNumberWorking % 10;
        ccNumberWorking /= 100;
    }

    while (ccNumber > 0)
    {
        ccNumber /= 10;
        wn = (ccNumber % 10) * 2;

        if (wn > 9)
        {
            sum += (wn % 10) + (wn / 10);
        }
        else
        {
            sum += wn;
        }
        ccNumber /= 10;
    }

    return sum % 10 == 0;
}

void printCreditCardBrand(long ccn)
{
    if ((ccn >= 34e13 && ccn < 35e13) || (ccn >= 37e13 && ccn < 38e13))
        printf("AMEX\n");
    else if ((ccn >= 51e14 && ccn < 56e14))
        printf("MASTERCARD\n");
    else if ((ccn >= 4e12 && ccn < 5e12) || (ccn >= 4e15 && ccn < 5e15))
        printf("VISA\n");
    else
        printf("INVALID\n");
}