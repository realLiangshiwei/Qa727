import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Qa727',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44349',
    redirectUri: baseUrl,
    clientId: 'Qa727_App',
    responseType: 'code',
    scope: 'offline_access Qa727',
  },
  apis: {
    default: {
      url: 'https://localhost:44358',
      rootNamespace: 'Qa727',
    },
  },
} as Environment;
