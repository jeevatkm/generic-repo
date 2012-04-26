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
package com.myjeeva.ad;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import javax.naming.NamingEnumeration;
import javax.naming.NamingException;
import javax.naming.directory.Attributes;
import javax.naming.directory.SearchResult;

/**
 * Sample program how to use ActiveDirectory class in Java
 * 
 * @filename SampleUsageActiveDirectory.java
 * @author <a href="mailto:jeeva@myjeeva.com">Jeevanandam Madanagopal</a>
 * @copyright &copy; 2010-2012 www.myjeeva.com
 */
public class SampleUsageActiveDirectory {

	/**
	 * @param args
	 * @throws NamingException 
	 */
	public static void main(String[] args) throws NamingException, IOException {
		System.out.println("\n\nQuerying Active Directory Using Java");
		System.out.println("------------------------------------");
		String domain = "";
		String username = "";
		String password = "";
		String choice = "";
		String searchTerm = "";
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		
		System.out.println("Provide username & password for connecting AD");
		System.out.println("Enter Domain:");			
		domain = br.readLine();
		System.out.println("Enter username:");			
		username = br.readLine();			
		System.out.println("Enter password:");
		password = br.readLine();
		System.out.println("Search by username or email:");
		choice = br.readLine();
		System.out.println("Enter search term:");
		searchTerm = br.readLine();
		
		//Creating instance of ActiveDirectory
        ActiveDirectory activeDirectory = new ActiveDirectory(username, password, domain);
        
        //Searching
        NamingEnumeration<SearchResult> result = activeDirectory.searchUser(searchTerm, choice, null);
        
        if(result.hasMore()) {
			SearchResult rs= (SearchResult)result.next();
			Attributes attrs = rs.getAttributes();
			String temp = attrs.get("samaccountname").toString();
			System.out.println("Username	: " + temp.substring(temp.indexOf(":")+1));
			temp = attrs.get("givenname").toString();
			System.out.println("Name         : " + temp.substring(temp.indexOf(":")+1));
			temp = attrs.get("mail").toString();
			System.out.println("Email ID	: " + temp.substring(temp.indexOf(":")+1));
			temp = attrs.get("cn").toString();
			System.out.println("Display Name : " + temp.substring(temp.indexOf(":")+1) + "\n\n"); 
		} else  {
			System.out.println("No search result found!");
		}

		//Closing LDAP Connection
        activeDirectory.closeLdapConnection();
	}
}
