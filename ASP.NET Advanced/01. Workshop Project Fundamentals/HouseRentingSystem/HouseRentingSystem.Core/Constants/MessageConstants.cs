﻿namespace HouseRentingSystem.Core.Constants;

public static class MessageConstants
{
    public const string RequiredMessage = "The {0} field is required!";
    public const string LengthMessage = "The field {0} must be between {2} and {1} characters long!";
    public const string PhoneExists = "Phone number already exists, please enter another one!";
    public const string HasRents = "You shouldn't have rents in order to become agent!";
}
