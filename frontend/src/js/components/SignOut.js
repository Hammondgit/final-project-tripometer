import Utility from "../utility";
import AllRequest from "../allRequest";
import {UsersController} from "../constants";
import cookie from "./cookie";
import main from "../main";
import header from "./header";




export default { 
    SignOut
}



function SignOut(){
   console.log("Signout");
   cookie.deleteCookie("UserName");  
   cookie.deleteCookie("UserId"); 
   main.Home();
   header.setup();
}
    