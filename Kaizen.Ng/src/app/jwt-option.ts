import { LocalService } from "src/services/local.service";

export function jwtFactory(localService : LocalService) {
    return {
      tokenGetter: () => {
        return localService.get("auth-token");
      }
    }
  }