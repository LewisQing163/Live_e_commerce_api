import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Text_Abp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44332',
    redirectUri: baseUrl,
    clientId: 'Text_Abp_App',
    responseType: 'code',
    scope: 'offline_access Text_Abp',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44332',
      rootNamespace: 'Text_Abp',
    },
  },
} as Environment;
