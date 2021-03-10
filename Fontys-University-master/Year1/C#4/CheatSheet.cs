Recursion
-------------------------------------------------------------
if (n==0)
{
	return 0;
}
else
{
	int sum = getSumOfDonationsAbove(limit, n - 1);
	if (this.donations[n-1].Amount > limit)
	{
		return sum + this.donations[n - 1].Amount;
	}
	else
	{
		return sum;
	}
}

-------------------------------------------------------------
if (n == 0)
	return -1;
else
{
	if (myCars[n - 1].Brand.Equals("Ferrari"))
	{
		int maxPriceOfTheRest = getMaxPriceFerrari(n - 1);
		if (myCars[n - 1].CurrentPrice > maxPriceOfTheRest)
			return myCars[n - 1].CurrentPrice;
		else
			return maxPriceOfTheRest;
	}
	else
		return getMaxPriceFerrari(n - 1);
}

-------------------------------------------------------------
if (n == 0 || n==1)
{
	return 0;
}
else
{
	int counter = getNumberOfTwins(n - 1);
	if (this.donations[n - 1].Amount + this.donations[n - 2].Amount == 500)
	{
		return counter + 1;
	}
	else
	{
		return counter;
	}
}

-------------------------------------------------------------
private int getHighestRank(int n)
{
	if (n == 1) 
	{ return this.racers.ElementAt(0).Rank; }
	else
	{
		int temp = getHighestRank(n - 1);
		if(temp< this.racers.ElementAt(n-1).Rank)
		{ 
			return this.racers.ElementAt(n-1).Rank; 
		}
		else { return temp; }
	}

}

Sorting
-------------------------------------------------------------

public class Drumble : IComparable<Drumble>

public void sortOnNumberOfDonations_Name()
{
	//todo, assignment 1
	this.startups.Sort(new Comparison<StartUp>(mySortMethod));
}
public int mySortMethod(StartUp firstStartup, StartUp secondStartup)
{
	int differenceNrOfDonations = firstStartup.getNrOfDonations() - secondStartup.getNrOfDonations();
	if (differenceNrOfDonations != 0)
	{
		return differenceNrOfDonations;
	}
	else
	{
		return firstStartup.Name.CompareTo(secondStartup.Name);
	}
}

public void SortOnTotalDonations()
{
	//todo, assignment 2
	this.startups.Sort();
}

public int CompareTo(StartUp other)
{
	return other.getTotalOfDonations() - this.getTotalOfDonations();
}

-------------------------------------------------------------
public void sortByBrandTypeAndPrice()
{
	// to do: assignment 1
	this.myCars.Sort(new Comparison<Car>(compareByBrandTypeAndPrice));
}

public void sortByBrandTypeAndPrice()
{
	// to do: assignment 1
	this.myCars.Sort(new Comparison<Car>(compareByBrandTypeAndPrice));
}

// For assignment 1, sorting
public int compareByBrandTypeAndPrice(Car first, Car second)
{
	int brandDifference = first.Brand - second.Brand;
	if (brandDifference == 0)
	{
		int typeDifference = first.Type.CompareTo(second.Type);
		if (typeDifference == 0)
		{
			// Brand and type are the same, so sort on price in descending order
			return second.CurrentPrice.CompareTo(first.CurrentPrice);
		}
		else
			return typeDifference; // Brand is the same, sort on type
	}
	else
		return brandDifference; // Sort on brand
}

public void sortByYear()
        {
            // to do: assignment 2
            this.myCars.Sort();
        }
// for assignment 2, sorting
public int CompareTo(Car other)
{
	return other.Year - this.Year; // sort on year descending
}




NODE

private Item theItem; //the item it refers to
private Node next;    // the next node it refers to; null if there does not exist a next node

public Node(Item aItem)
{
	this.theItem = aItem;
	this.next = null;
}

public Item getItem() { return this.theItem; }

public Node getNext() { return this.next; }
public void setNext(Node n) { this.next = n; }


LINKEDLIST

private Node first;
private int itemCounter;

public LinkedListOfBigDonations()
{
	this.first = null;
	this.itemCounter = 0;
}
public void addNode(string name)
{
	if (first == null)
	{
		Node temp = new Node(i);
		first  = temp;
		last = temp;
		itemCounter++;
	}
	else
	{
		//add at the start of the list

		Node temp = new Node(name);
		temp.setNext(first);
		first = temp;

		//add at the end of the list

		Node temp = new Node(name);
		last.setNext(temp);
		last = temp;

		itemCounter++;
	}
}

public void RemoveFromStart()
{
   if (itemCounter > 0)
   {
     first = first.getNext();
     itemCounter--;
   }
   else
   {
     Console.WriteLine("No element exist in this linked list.");
   }
}

public string PrintAllNodes()
{
	//Traverse from head
	string temp = first.getItem() + "->";
	Node curr = first;
	while (curr.getNext() != null)
	{
		curr = curr.getNext();
		temp += curr.getItem();
		temp +="->";
	}
	temp+= "NULL";
	return temp;
}

public int nrOfTestDrivesWithCarsOfBrand(string brand)
{
	if (this.first == null)
		return 0;
	else
	{
		Node curr = this.first;
		int counter = 0;
		while (curr != null)
		{
			if (curr.getCar().Brand.Equals(brand))
			{
				counter++;
			}
			curr = curr.getNext();
		}
		return counter;
	}
}

