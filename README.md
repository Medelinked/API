# Medelinked Health Cloud API
Medelinked provide a HTTP API for partners to use to build applications that interact with a user’s
health account. The API enables partners build custom white labelled solutions that allow them
to:
- Register new user
- Push their apps to existing Medelinked users
- Add health and wellness records to a user's account
- Read health and wellness information to provide interesting visual indicators around a person's health and wellbeing.
- Show emergency health information (ICE) 
- Provide features and functionality for health providers to collaborate with individuals around their health

The API is extremely simple to use and returns data in JSON format. All application developers will
be provided with a Provider Key which they will need to use during any calls made to the API. Any
applications will need to get user consent to sign in or register. Applications cannot interact with
user data without the user being authenticated first.

## API Resources
The Medelinked API uses GET and POST verbs to interact with resources that push / pull data from a user’s account. The core URI for the API is:
    
    https://app.Medelinked.com/api/

JSON is used as the payload format for data that is pushed or pulled via the GET & POST requests.

## Provider Key
Before you can start developing against the API you will need a Provider Key which is used for 2 reasons:
- Authenticate requests made from your application
- Records updated / added via your application will be marked as having been generated by your app as the source

The Provider Key should be passed in the body of a POST request along with other parameters for the appropriate resources as outlined below.

In order to request your Provider Key, simply sign up as part of the Medelinked Partner Development Program at http://www.medelinked.com/healthcloud/

## User API
The User API allows developers to build applications that target the individual directly.  User's can authenticate against their Medelinked account and authorise the application to access their health data as well allow the user to collect further health data into their account.

The User API can be accessed via the following URI
    
    https://app.medelinked.com/api/user/

Sample code on how to use the User API can be found in the PHP example in the repository.

### Authenticating Users
In order to authenticate users to access their records, you need to call the following URI:
    
    POST https://app.Medelinked .com/api/user/authenticate

The JSON structure to be included in the body of the request should include the following:
    
    { “UserCredentials” :
        { 
            “Username” : “ jas.singh@Medelinked.com ”,
            “Password” : “jdfhjdsfh8”,
            “ProviderKey” : “jfh847d7oadsfhjdsfdhsmadfd7f8”
        }
    }

## Provider API
The Provider API is to be used by the 3rd party Health Provider or Partner applications that wish to access their customers / patients on the Medelinked Platform. The API is similar to the User focused API detailed in the previous sections of this document.

The Provider API can be accessed via the following URI:
    
    https://app.medelinked.com/api/provider/

Sample code on how to use the User API can be found in the C# example in the repository.

### Authentication
Before you can access the Partner API, you will need to authenticate / connect with the Medelinked platform using your Provider Key and Password that have provided to you by Medelinked when you registered with us.

In order to authenticate as a provider, you need to call the following URI:
    
    POST https://app.Medelinked.com/api/provider/connect

The JSON structure to be included in the body of the request should include the following:
    
    { “ProviderCredentials” :
        { 
            “ProviderID” : “jfh847d7oadsfhjdsfdhsmadfd7f8”,
            “Passcode” : “jdfhjdsfh8”
        }
    }

## Further Information
To find out more about the Medelinked Health Cloud and support with using the API please visit http://www.medelinked.com/healthcloud/ or email us at developers@medelinked.com

