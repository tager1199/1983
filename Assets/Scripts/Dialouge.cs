using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialouge : MonoBehaviour {
  Queue Dialogue = new Queue();
  List<string> AllText = new List<string>();

void Start ()	{
  //bar NPCs
  AllText.Add("I'm so happy I have such amazing best friends, and I love Lisa so much.");//before transmission
  AllText.Add("I’m going to be torn apart!! Lisa!!");
  AllText.Add("There’s no sense crying over every mistake. You just keep on trying till you run out of cake."); //before
  AllText.Add("I’m not even angry. I’m being so sincere right now.");

  //BAR GOER 1 - SOLDIER - IF MC IS DRUNK
  AllText.Add("What the hell is your problem?! ");
  AllText.Add("God, you stink of vodka.");
  AllText.Add("Woah woah woah, buddy. Not letting you go without an apology. That bloody hurt.");

  //BAR GOER 2 - AFTER BAR GOER 1 LOSES FIGHT
  AllText.Add("Look how hard his head hit the floor! He’s dead!");
  AllText.Add("You did this. You take him to the hospital.");

  //BAR GOER 1 - SOLDIER - IF MC IS SOBER
  AllText.Add("What’ssss your name?");
  AllText.Add("You went... to TOVMI…. for high school? In Vladivostok?");

  //                            SOLDIER AT CHECKPOINT
  //MILITARY PATH - SOLDIER
  AllText.Add("Stop right there!");
  AllText.Add("Who are you? You have no clearance to be entering this bunker. Get in line!");

  //USE TAGS TO PRETEND TO BE SOLDIER
  AllText.Add("Right. Sorry for mistrusting you comrade, come in.");
  AllText.Add("You’ve heard about the missile launch?");
  AllText.Add("You haven’t heard?");
  AllText.Add("Colonel Petrov is hesitating to fire our own nuclear armaments in retaliation against the American dogs. ");
  AllText.Add("Our ‘Oko’ detection system is foolproof, we’ve been told as much a thousand times. How could he deny the proof when it’s right there in front of him?");
  AllText.Add("We’ll burn in our homes while the Americans get away with killing us all. He’s a damned traitor. ");
  AllText.Add("Claims it’s a false alarm, but I haven’t heard his explanation behind that line of thinking.");
  AllText.Add("He’s an American agent, I swear it on my mother’s grave. ");
  AllText.Add("You do that, comrade. ");

  //CLAIM TO BE RETURNING DOG TAGS
  AllText.Add("You have ten seconds to explain how you acquired these.");
  AllText.Add("Go on in. Give the tags to Petrov’s second-in-command. He’s sure to be too busy to deal with this.");

  //CIVILIAN
  AllText.Add("Plenty of people want to get into this bunker before the nukes hit.");
  AllText.Add("Why should we let you in first?");
  AllText.Add("You have security clearance. Go inside. Now.");


  //                                  PETROV
  //Soldier in fatigues
  AllText.Add("I don’t want anyone else in here. This is heated enough of a situation as it is. Begone.");

  //Delivering TAGS
  AllText.Add("You came this far to achieve a noble, but ultimately meaningless goal?");
  AllText.Add("You seem like just the kind of person from whom I’d like to hear military advice.");
  AllText.Add("I’m not joking. Tell me what you think, before it’s too late.");


  //CIVILIAN PATH
  AllText.Add("Do you have a death wish, or are you just an opportunist who wants to try and change history?");
  AllText.Add("You seem braver than half the people in this room. Tell me what you think of this, civilian.");


  //AFTERWARDS, NO MATTER WHAT
  AllText.Add("Whatever you make of this will go against what half of the rest of the people in the room believe. ");
  AllText.Add("I am a precious few minutes and a button press away from sending the rest of the world to its doom, or going with my first instinct of inaction under the belief that the Oko warning system is transmitting a false alarm.");
  AllText.Add("Five nuclear missiles are highlighted as approaching us to strike.");
  AllText.Add("Why wouldn’t the US send all of their nuclear arms? Why but a fraction of them?");

}


}
