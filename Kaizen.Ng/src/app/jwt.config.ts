import { LocalService } from "src/services/local.service";

export function jwtOptionFactory(localService : LocalService) {
    return {
        tokenGetter: () => {
            return localService.get("auth-token");
        }
    }
}