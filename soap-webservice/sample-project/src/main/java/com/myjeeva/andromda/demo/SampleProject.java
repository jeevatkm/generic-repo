package com.myjeeva.andromda.demo;

import java.io.FileNotFoundException;
import java.util.Arrays;
import java.util.Date;

import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;
import org.springframework.util.Log4jConfigurer;

import com.myjeeva.andromda.demo.exceptions.DeclaredException;
import com.myjeeva.andromda.demo.service.SampleWebServiceSEI;
import com.myjeeva.andromda.demo.vo.DatesVO;
import com.myjeeva.andromda.demo.vo.GreetingVO;
import com.myjeeva.andromda.demo.vo.StringsVO;

/**
 * @author jeeva
 *
 */
public class SampleProject {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		/** Constant <code>LOG</code> */
        final Log LOG = LogFactory.getLog(SampleProject.class);
		/**
         * Initializing App Context
         */
        try {
                LOG.info("Initializing Log4j configuration");
                Log4jConfigurer.initLogging("classpath:log4j.xml");
                ApplicationContext context = new ClassPathXmlApplicationContext("applicationContext-WebServiceClient.xml");
                
                LOG.info("Web Service Client App Context Successfully\n\n");                           
                SampleWebServiceSEI sampleWebServiceSEI = (SampleWebServiceSEI)context.getBean("sampleWebserviceServiceClient");
                
                LOG.info("Invoking getServiceGreeting Method");
                GreetingVO greetingVO = sampleWebServiceSEI.getServiceGreeting();
                System.out.println(greetingVO.getMessage() + "\n");
                
                LOG.info("Invoking getStrings Method");
                StringsVO stringsVO = sampleWebServiceSEI.getStrings("welcome to Sample Project", " by www.myjeeva.com");
                System.out.println(stringsVO.getOptional() + stringsVO.getRequired() + "\n");              
                
        } catch (FileNotFoundException e) {
                LOG.error("Error Occurred " + "\n" + e.getMessage());
        } 
	}

}
