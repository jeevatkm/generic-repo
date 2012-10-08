/**
 * The MIT License
 *
 * Copyright (c) 2010-2012 www.myjeeva.com
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE. 
 * 
 */
package com.myjeeva.comparator.example;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Locale;

import com.myjeeva.comparator.GenericComparator;
import com.myjeeva.comparator.example.vo.PersonVO;

/**
 * Demonstration of GenericComparator
 * 
 * @author <a href="mailto:jeeva@myjeeva.com">Jeevanandam Madanagopal</a>
 */
@SuppressWarnings("unchecked")
public class SampleUsageGenericComparator {

	/**
	 * @param args
	 * @throws ParseException 
	 */
	public static void main(String[] args) throws ParseException {
				
		PersonVO person1 = new PersonVO();
		person1.setId(10001);
		person1.setName("Jacob");
		person1.setHeight(5.2F);
		person1.setEmailId("jacob@example.example");
		person1.setSalary(10500L);
		person1.setDob(new SimpleDateFormat("MMMM d, yyyy", Locale.ENGLISH).parse("Jan 1, 1970"));
		
		PersonVO person2 = new PersonVO();
		person2.setId(10002);
		person2.setName("Emily");
		person2.setHeight(5.4F);
		person2.setEmailId("emily@example.example");
		person2.setSalary(9500L);
		person2.setDob(new SimpleDateFormat("MMMM d, yyyy", Locale.ENGLISH).parse("Feb 1, 1985"));
		
		PersonVO person3 = new PersonVO();
		person3.setId(10003);
		person3.setName("Andy");
		person3.setHeight(5.0F);
		person3.setEmailId("andy@example.example");
		person3.setSalary(11500L);
		person3.setDob(new SimpleDateFormat("MMMM d, yyyy", Locale.ENGLISH).parse("Dec 1, 1980"));
		
		PersonVO person4 = new PersonVO();
		person4.setId(10004);
		person4.setName("Chris");
		person4.setHeight(5.5F);
		person4.setEmailId("chris@example.example");
		person4.setSalary(8500L);
		person4.setDob(new SimpleDateFormat("MMMM d, yyyy", Locale.ENGLISH).parse("Aug 1, 1975"));
		
		PersonVO person5 = new PersonVO();
		person5.setId(10005);
		person5.setName("Jeeva");
		person5.setHeight(5.7F);
		person5.setEmailId("sample@example.example");
		person5.setSalary(10000L);
		person5.setDob(new SimpleDateFormat("MMMM d, yyyy", Locale.ENGLISH).parse("Mar 1, 1990"));
		
		List<PersonVO> persons = new ArrayList<PersonVO>();
		persons.add(person2);
		persons.add(person1);
		persons.add(person4);
		persons.add(person3);
		persons.add(person5);
		
		System.out.println("Generic Comparator Execution Result with Sample Person List example");
		System.out.println("===================================================================\n");
		
		System.out.println("Initial Set of Inputs");
		System.out.println("*********************");
		displayPersonList(persons);
		
		Collections.sort(persons, new GenericComparator("id", true));
		System.out.println("\nBy Id field Sorting (Integer datatype)");
		System.out.println("****************************************");
		displayPersonList(persons);

		Collections.sort(persons, new GenericComparator("name", true));
		System.out.println("\nBy Name field Sorting (String datatype)");
		System.out.println("*****************************************");
		displayPersonList(persons);
		
		Collections.sort(persons, new GenericComparator("height", false));
		System.out.println("\nBy Height field Sorting Desc (Float datatype)");
		System.out.println("*********************************************");
		displayPersonList(persons);
		
		Collections.sort(persons, new GenericComparator("emailId", true));
		System.out.println("\nBy Email Address field Sorting (String datatype)");
		System.out.println("************************************************");
		displayPersonList(persons);
		
		Collections.sort(persons, new GenericComparator("dob", true));
		System.out.println("\nBy DOB field Sorting (Date datatype)");
		System.out.println("************************************");
		displayPersonList(persons);
		
		Collections.sort(persons, new GenericComparator("salary", false));
		System.out.println("\nBy Salary field Sorting Desc (Long datatype)");
		System.out.println("********************************************");
		displayPersonList(persons);	
		
	}
	
	private static void displayPersonList(List<PersonVO> persons) {		
		System.out.println("Id\tName\tHeight\tEmail Address\t\tDOB\t\tSalary");
		System.out.println("--\t----\t------\t-------------\t\t---\t\t------");
		SimpleDateFormat df = new SimpleDateFormat("yyyy-MM-dd");
		for(PersonVO p : persons) {
			System.out.println(String.format("%s\t%s\t%s\t%s\t%s\t%s", p.getId(), p.getName(), p.getHeight(), p.getEmailId(), df.format(p.getDob()), p.getSalary()));
		}
	}
}
