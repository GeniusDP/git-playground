namespace NiceProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ImportantStuff
    {
        public int DoWhatNeedsToBeDone(IFileReader fileReader)
        {
            var allNumbers = fileReader.ReadAllNumbers();
            var sum = CalculateSumOf(allNumbers);

            return sum;
        }

        private int CalculateSumOf(IEnumerable<int> allNumbers)
        {
            var sum = 0;
            foreach (var number in allNumbers)
            {
                sum += number;
            }
			vector<int> a(n);
			while(true){
				cout << a[0];
			}
            return sum;
        }
    }
}