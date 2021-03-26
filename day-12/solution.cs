
//Ctor
public Student(string firstName, string lastName, int id, int[] scores):base()
    {
    this.firstName = firstName;
    this.lastName = lastName;
    this.id = id;
    this.testScores = scores;
}


//Calculate method
public char Calculate()
{
    int ave = 0;
    int sum = 0;
    int score = 0;

    for (int i = 0; i < testScores.Length; i++)
    {
        sum += testScores[i];

    }
    score = testScores.Length;
    ave = sum / score;

    if (ave >= 90 && ave <= 100)
    {
        return 'O';
    }
    else if (ave >= 80 && ave <= 90)
    {
        return 'E';
    }
    else if (ave >= 70 && ave <= 80)
    {
        return 'A';
    }
    else if (ave >= 55 && ave <= 70)
    {
        return 'P';
    }
    else if (ave >= 40 && ave <= 55)
    {
        return 'D';
    }
    else if (ave <= 40)
    {
        return 'T';
    }

    return '0';
}
}