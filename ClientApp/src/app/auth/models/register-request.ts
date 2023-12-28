import { Gender } from "@shared/enums/gender";
import { AuthenticateRequest } from "./authenticate-request";

export interface RegisterRequest extends AuthenticateRequest {
    firstName: string;
    lastName: string;
    gender: Gender;
    countryCode: string;
    languageCodes: string[];
    targetLanguageCodes: string[];
}