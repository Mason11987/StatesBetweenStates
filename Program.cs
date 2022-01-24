using System.Collections.Generic;

Dictionary<(string, string), int> StatesBetweenstates = new();
StatesBetweenstates[("Washington", "Oregon")] = 1;
StatesBetweenstates[("Washington", "Idaho")] = 1;

StatesBetweenstates[("Oregon", "California")] = 1;
StatesBetweenstates[("Oregon", "Nevada")] = 1;
StatesBetweenstates[("Oregon", "Idaho")] = 1;

StatesBetweenstates[("California", "Nevada")] = 1;
StatesBetweenstates[("California", "Arizona")] = 1;

StatesBetweenstates[("Nevada", "Idaho")] = 1;
StatesBetweenstates[("Nevada", "Utah")] = 1;
StatesBetweenstates[("Nevada", "Oregon")] = 1;
StatesBetweenstates[("Nevada", "Arizona")] = 1;

StatesBetweenstates[("Idaho", "Montana")] = 1;
StatesBetweenstates[("Idaho", "Wyoming")] = 1;
StatesBetweenstates[("Idaho", "Utah")] = 1;

StatesBetweenstates[("Arizona", "Utah")] = 1;
StatesBetweenstates[("Arizona", "New Mexico")] = 1;

StatesBetweenstates[("Utah", "Wyoming")] = 1;
StatesBetweenstates[("Utah", "Colorado")] = 1;

StatesBetweenstates[("Montana", "North Dakota")] = 1;
StatesBetweenstates[("Montana", "South Dakota")] = 1;
StatesBetweenstates[("Montana", "Wyoming")] = 1;

StatesBetweenstates[("Wyoming", "South Dakota")] = 1;
StatesBetweenstates[("Wyoming", "Nebraska")] = 1;
StatesBetweenstates[("Wyoming", "Colorado")] = 1;

StatesBetweenstates[("Colorado", "Nebraska")] = 1;
StatesBetweenstates[("Colorado", "Kansas")] = 1;
StatesBetweenstates[("Colorado", "Oklahoma")] = 1;
StatesBetweenstates[("Colorado", "New Mexico")] = 1;

StatesBetweenstates[("New Mexico", "Oklahoma")] = 1;
StatesBetweenstates[("New Mexico", "Texas")] = 1;

StatesBetweenstates[("North Dakota", "Minnesota")] = 1;
StatesBetweenstates[("North Dakota", "South Dakota")] = 1;

StatesBetweenstates[("South Dakota", "Minnesota")] = 1;
StatesBetweenstates[("South Dakota", "Iowa")] = 1;
StatesBetweenstates[("South Dakota", "Nebraska")] = 1;

StatesBetweenstates[("Kansas", "Missouri")] = 1;
StatesBetweenstates[("Kansas", "Oklahoma")] = 1;

StatesBetweenstates[("Oklahoma", "Missouri")] = 1;
StatesBetweenstates[("Oklahoma", "Arkansas")] = 1;
StatesBetweenstates[("Oklahoma", "Texas")] = 1;

StatesBetweenstates[("Texas", "Arkansas")] = 1;
StatesBetweenstates[("Texas", "Louisiana")] = 1;

StatesBetweenstates[("Minnesota", "Michigan")] = 1; //Weird
StatesBetweenstates[("Minnesota", "Wisconsin")] = 1;
StatesBetweenstates[("Minnesota", "Iowa")] = 1;

StatesBetweenstates[("Iowa", "Wisconsin")] = 1;
StatesBetweenstates[("Iowa", "Illinois")] = 1;
StatesBetweenstates[("Iowa", "Missouri")] = 1;

StatesBetweenstates[("Missouri", "Illinois")] = 1;
StatesBetweenstates[("Missouri", "Kentucky")] = 1;
StatesBetweenstates[("Missouri", "Tennessee")] = 1;
StatesBetweenstates[("Missouri", "Arkansas")] = 1;

StatesBetweenstates[("Arkansas", "Tennessee")] = 1;
StatesBetweenstates[("Arkansas", "Mississippi")] = 1;
StatesBetweenstates[("Arkansas", "Louisiana")] = 1;

StatesBetweenstates[("Louisiana", "Mississippi")] = 1;

StatesBetweenstates[("Wisconsin", "Michigan")] = 1;
StatesBetweenstates[("Wisconsin", "Illinois")] = 1;

StatesBetweenstates[("Illinois", "Michigan")] = 1;
StatesBetweenstates[("Illinois", "Indiana")] = 1;
StatesBetweenstates[("Illinois", "Kentucky")] = 1;

StatesBetweenstates[("Michigan", "Indiana")] = 1;
StatesBetweenstates[("Michigan", "Ohio")] = 1;

StatesBetweenstates[("Indiana", "Ohio")] = 1;
StatesBetweenstates[("Indiana", "Kentucky")] = 1;

StatesBetweenstates[("Kentucky", "Ohio")] = 1;
StatesBetweenstates[("Kentucky", "West Virginia")] = 1;
StatesBetweenstates[("Kentucky", "Virginia")] = 1;
StatesBetweenstates[("Kentucky", "Tennessee")] = 1;

StatesBetweenstates[("Tennessee", "Virginia")] = 1;
StatesBetweenstates[("Tennessee", "North Carolina")] = 1;
StatesBetweenstates[("Tennessee", "Mississippi")] = 1;
StatesBetweenstates[("Tennessee", "Alabama")] = 1;
StatesBetweenstates[("Tennessee", "Georgia")] = 1;

StatesBetweenstates[("Mississippi", "Alabama")] = 1;

StatesBetweenstates[("Alabama", "Georgia")] = 1;
StatesBetweenstates[("Alabama", "Florida")] = 1;

StatesBetweenstates[("Ohio", "Pennsylvania")] = 1;
StatesBetweenstates[("Ohio", "West Virginia")] = 1;

StatesBetweenstates[("West Virginia", "Pennsylvania")] = 1;
StatesBetweenstates[("West Virginia", "Maryland")] = 1;
StatesBetweenstates[("West Virginia", "Virginia")] = 1;

StatesBetweenstates[("Florida", "Georgia")] = 1;

StatesBetweenstates[("Georgia", "South Carolina")] = 1;
StatesBetweenstates[("Georgia", "North Carolina")] = 1;

StatesBetweenstates[("South Carolina", "North Carolina")] = 1;

StatesBetweenstates[("North Carolina", "Virginia")] = 1;

StatesBetweenstates[("Virginia", "Maryland")] = 1;

StatesBetweenstates[("Maryland", "Pennsylvania")] = 1;
StatesBetweenstates[("Maryland", "Delaware")] = 1;

StatesBetweenstates[("Delaware", "Pennsylvania")] = 1;
StatesBetweenstates[("Delaware", "New Jersey")] = 1;

StatesBetweenstates[("Pennsylvania", "New York")] = 1;
StatesBetweenstates[("Pennsylvania", "New Jersey")] = 1;

StatesBetweenstates[("New Jersey", "New York")] = 1;

StatesBetweenstates[("New York", "Connecticut")] = 1;
StatesBetweenstates[("New York", "Massachusetts")] = 1;
StatesBetweenstates[("New York", "Vermont")] = 1;

StatesBetweenstates[("Connecticut", "Massachusetts")] = 1;
StatesBetweenstates[("Connecticut", "Rhode Island")] = 1;

StatesBetweenstates[("Rhode Island", "Massachusetts")] = 1;

StatesBetweenstates[("Massachusetts", "Vermont")] = 1;
StatesBetweenstates[("Massachusetts", "New Hampshire")] = 1;
StatesBetweenstates[("Massachusetts", "Maine")] = 1;

StatesBetweenstates[("Vermont", "New Hampshire")] = 1;

StatesBetweenstates[("New Hampshire", "Maine")] = 1;

Dictionary<(string, string), int> swappedStates = new();

foreach (var pair in StatesBetweenstates)
{
    if (!StatesBetweenstates.ContainsKey((pair.Key.Item2, pair.Key.Item1)))
    {
        swappedStates.Add((pair.Key.Item2, pair.Key.Item1), pair.Value);
    }
}

foreach (var swapped in swappedStates)
{
    StatesBetweenstates.Add(swapped.Key, swapped.Value);
}

var pops = File.ReadAllLines($@"D:\Downloads\pops.csv").Select(x => (name: x.Split(',')[0],pop: int.Parse(x.Split(',')[1]))).ToList();

var stateNames = pops.Select(x => x.name).ToArray();

var totalPop = pops.Sum(x => x.pop);

//validate names
foreach (var sbss in StatesBetweenstates)
{
    if (!stateNames.Contains(sbss.Key.Item1))
        throw new InvalidOperationException();
    if (!stateNames.Contains(sbss.Key.Item2))
        throw new InvalidOperationException();
}

var borders = stateNames.ToDictionary(stateName => stateName, stateName => StatesBetweenstates.Count(x => x.Key.Item1 == stateName));

bool hasMisses = true;
int maxGap = 1;
while (hasMisses)
{
    hasMisses = false;
    foreach (var stateNameA in stateNames)
    {
        foreach (var stateNameB in stateNames)
        {
            if (!StatesBetweenstates.ContainsKey((stateNameA, stateNameB)))
            {
                if (StatesBetweenstates.ContainsKey((stateNameB, stateNameA)))
                    StatesBetweenstates[(stateNameA, stateNameB)] = StatesBetweenstates[(stateNameB, stateNameA)];
                else
                {
                    if (stateNameA == stateNameB)
                    {
                        StatesBetweenstates[(stateNameA, stateNameB)] = 0;
                        StatesBetweenstates[(stateNameB, stateNameA)] = 0;
                    }
                    else
                    {
                        var distance = DetermineStatesBetweenStates(stateNameA, stateNameB, StatesBetweenstates, maxGap);
                        if (distance != -1)
                        {
                            StatesBetweenstates[(stateNameA, stateNameB)] = distance;
                            StatesBetweenstates[(stateNameB, stateNameA)] = StatesBetweenstates[(stateNameA, stateNameB)];
                        }
                        else
                        {
                            hasMisses = true;
                        }
                    }

                }
            }
        }
    }
    maxGap++;
}


int DetermineStatesBetweenStates(string stateNameA, string stateNameB, Dictionary<(string, string), int> statesBetweenstates, int maxGap)
{
    var aNeighborsWithValue = statesBetweenstates.Where(x => x.Key.Item1 == stateNameA && x.Value <= maxGap).Select(x => (x.Key.Item2, x.Value));
    var bNeighborsWithValue = statesBetweenstates.Where(x => x.Key.Item1 == stateNameB && x.Value <= maxGap).Select(x => (x.Key.Item2, x.Value));

    var matchStates = aNeighborsWithValue.Where(aN => bNeighborsWithValue.Select(bnwv => bnwv.Item1).ToArray().Contains(aN.Item1)).Select(x => x.Item1).ToList();
    var matchStatesWithTotals = matchStates.Select(x => (x, aNeighborsWithValue.FirstOrDefault(aN => aN.Item1 == x).Value + bNeighborsWithValue.FirstOrDefault(bN => bN.Item1 == x).Value));

    if (matchStatesWithTotals.Any())
    {
        var minValue = matchStatesWithTotals.Min(x => x.Item2);
        var newValue = minValue;
        Console.WriteLine($"{stateNameA} to {stateNameB} in {newValue} steps");
        return newValue;
    }
    return -1;
}

foreach (var sbss in StatesBetweenstates.OrderBy(x => x.Value))
{
    Console.WriteLine($"{sbss.Key.Item1} to {sbss.Key.Item2} = {sbss.Value} states");
}

int numberOfCrossings = 0;
int numberofRuns = 0;
Random rnd = new Random();

for (int i = 0; i < 100000000; i++)
{
    int popA = rnd.Next(totalPop);
    int popB = rnd.Next(totalPop);
    var stateA = GetStateForPop(popA, pops, totalPop);
    var stateB = GetStateForPop(popB, pops, totalPop);
    var steps = StatesBetweenstates[(stateA, stateB)];
    numberOfCrossings += steps;
    numberofRuns++;
}

Console.WriteLine($"{numberOfCrossings} in {numberofRuns} runs - Average {numberOfCrossings / (double)numberofRuns}");

string GetStateForPop(int popNum, List<(string name, int pop)> pops, int totalPop)
{
    var runningTotal = 0;
    foreach (var statePop in pops)
    {
        runningTotal += statePop.pop;
        if (runningTotal > popNum)
            return statePop.name;
    }
    throw new InvalidOperationException();
}

Console.WriteLine(pops);