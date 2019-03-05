using System;
using System.Collections.Generic;

namespace iterating_planets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of the planets in the solar system.
            List<string> planetList = new List<string>(){
                "Mercury", 
                "Venus", 
                "Earth", 
                "Mars" , 
                "Jupiter", 
                "Saturn", 
                "Neptune", 
                "Uranus", 
                "Pluto"
        };

            //List of dictionaries containing the name of a prove and the name of a planet that it has visited//
            List<Dictionary<string, string>> probes =  new List<Dictionary<string, string>>();
            //List of dictionaries = dict name (probes) probes.Add(new dictionary)
            probes.Add(new Dictionary<string, string>(){ {"Mercury", "Mariner-10"} });
            probes.Add(new Dictionary<string, string>(){ {"Mercury", "Mariner-12"} });
            probes.Add(new Dictionary<string, string>(){ {"Venus", "Vanera-7"} });
            probes.Add(new Dictionary<string, string>(){ {"Earth", "Voyager-1" } });
            probes.Add(new Dictionary<string, string>(){ {"Mars" ,"Mars-Rover" } });
            probes.Add(new Dictionary<string, string>(){ {"Jupiter", "Pioneer-11"} });
            probes.Add(new Dictionary<string, string>(){ {"Saturn", "Voyager-2" } });
            probes.Add(new Dictionary<string, string>(){ {"Neptune" , "VoyagerTwo" } });
            probes.Add(new Dictionary<string, string>(){ {"Uranus", "VoyagerTwo"} });
            probes.Add(new Dictionary<string, string>(){ {"Pluto", "Horizons"} });

            //iterate over the planetList inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.
                
            //iterate Planets
            foreach(string planet in planetList){
                //Create a list specific to the planet. Each planet will have it's own list called Matching probes
                List<string> matchingProbes = new List<string>();
                //iterte Probes
                foreach(Dictionary<string, string> probe in probes){
                    //getting a little more specific looking at each each key value pair.
                    foreach(KeyValuePair<string,string> kvp in probe){
                        //if the planet string is equal to the Key in the probes list (being the planet)
                        if(probe.ContainsKey(planet)){ 
                            //Need to add the value (probe)
                            matchingProbes.Add(kvp.Value);

                            //This would be the way to do it if I were to take out the KVP loop and use square bracket notation
                            // matchingProbes.Add(probe[planet]);
                        }

                }
            }
                //joining the strings that are in the matching probes list for each planet
                string seperatedList = String.Join("," , matchingProbes);
                //Writing the planets and the cooresponding probes seperated by a comma
                Console.WriteLine($"{planet}:{seperatedList}");

        }
    }
}
}
