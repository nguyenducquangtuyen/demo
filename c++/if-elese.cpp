int main()
{
	int selection;
	do
	{
		cout << "_____Please make a selection_____" << endl;
		cout << "1/ Addition" << endl;
		cout << "2/ Subtraction" << endl;
		cout << "3/ Multiplication" << endl;
		cout << "4/ Division" << endl;

		cout << "Your selection: "; 
		cin >> selection;

		cout << "Do something with your selection here" << endl;

	}while (selection >= 1 && selection <= 4);		

	system("pause");
	return 0;
}