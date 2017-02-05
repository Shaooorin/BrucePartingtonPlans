using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillDictionary {

	public static Dictionary<int,List<string>> skillDic = new Dictionary<int,List<string>>();

	static SkillDictionary(){
		skillDic.Add (1,new List<string>{"C-Sharp","10","You'll Fist Attack to Enemies by C-Sharp."});
		skillDic.Add (2,new List<string>{"JavaScript","30","You'll Fist Attack to Enemies by JavaScript."});
		skillDic.Add (3,new List<string>{"MySQL","12","You'll Fist Attack to Enemies by MySQL."});
		skillDic.Add (4,new List<string>{"Python","15","You'll Fist Attack to Enemies by Python."});
		skillDic.Add (5,new List<string>{"PHP","8","You'll Fist Attack to Enemies by PHP."});
		skillDic.Add (6,new List<string>{"Ruby","10","You'll Fist Attack to Enemies by Ruby."});
		skillDic.Add (7,new List<string>{"JAVA","15","You'll Fist Attack to Enemies by JAVA."});
		skillDic.Add (8,new List<string>{"BASIC","12","You'll Fist Attack to Enemies by BASIC."});
		skillDic.Add (9,new List<string>{"Swift","30","You'll Fist Attack to Enemies by Swift."});
		skillDic.Add (10,new List<string>{"FORTRAN","8","You'll Fist Attack to Enemies by FORTRAN."});

//		List<int> playerSkill = new List<int> ();
//		playerSkill.Add (1);
//		playerSkill.Add (3);
//		playerSkill.Add (5);
	}
}
